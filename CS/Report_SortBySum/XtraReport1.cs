using System;
using DevExpress.XtraReports.UI;
// ...

namespace Report_SortBySum {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        double totalUnits = 0;
        double pack = 15;

        // To calculate a custom summary function, for sorting groups against its result,
        // handle the following events of the GroupHeader band.
        private void GroupHeader1_SortingSummaryReset(object sender, EventArgs e) {
            // Reset the result each time a group is printed.
            totalUnits = 0;
        }

        private void GroupHeader1_SortingSummaryRowChanged(object sender, GroupSortingSummaryRowChangedEventArgs e) {
            // Calculate a summary.
            totalUnits += Convert.ToDouble(e.FieldValue);
        }

        private void GroupHeader1_SortingSummaryGetResult(object sender, GroupSortingSummaryGetResultEventArgs e) {
            // Round the result, so that a pack will be taken into account
            // even if it contains only one unit.
            e.Result = Math.Ceiling(totalUnits / pack);
            e.Handled = true;
        }

        // To display the summary function's result in the report,
        // handle the similar summary events of the XRLabel instance.
        private void xrLabel3_SummaryReset(object sender, EventArgs e) {
            totalUnits = 0;
        }

        private void xrLabel3_SummaryRowChanged(object sender, EventArgs e) {
            totalUnits += Convert.ToDouble(GetCurrentColumnValue("UnitsOnOrder"));
        }

        private void xrLabel3_SummaryGetResult(object sender, SummaryGetResultEventArgs e) {
            e.Result = Math.Ceiling(totalUnits / pack);
            e.Handled = true;
        }

    }
}
