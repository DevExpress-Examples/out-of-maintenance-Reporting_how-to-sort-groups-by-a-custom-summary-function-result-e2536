<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Report_SortBySum/Form1.cs) (VB: [Form1.vb](./VB/Report_SortBySum/Form1.vb))
* [XtraReport1.cs](./CS/Report_SortBySum/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/Report_SortBySum/XtraReport1.vb))
<!-- default file list end -->
# How to sort groups by a custom summary function result


<p>This example demonstrates how to sort groups by a custom summary function result.</p><p>To do this, via a GroupHeader band's <strong>SortingSummary</strong> property, set the <strong>XRGroupSortingSummary.Function</strong> to <strong>Custom</strong>, and handle the following events of the GroupHeader band: <strong>SortingSummaryReset</strong>, <strong>SortingSummaryRowChanged</strong> and <strong>SortingSummaryGetResult</strong>.</p><p>See also: <br />
- <a href="https://www.devexpress.com/Support/Center/p/E1763">How to sort groups by number of records in the group</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E810">How to insert page numbers for groups</a>.</p>

<br/>


