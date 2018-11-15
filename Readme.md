<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Q154045/Default.aspx) (VB: [Default.aspx](./VB/Q154045/Default.aspx))
* [Default.aspx.cs](./CS/Q154045/Default.aspx.cs) (VB: [Default.aspx](./VB/Q154045/Default.aspx))
<!-- default file list end -->
# How to highlight a clicked cell in the ASPxPivotGrid using client-side events


<p>This example demonstrates how to highlight a cell if the user clicks on it using client side events. The previously clicked cell background reverts to its normal.</p>


<h3>Description</h3>

<p>This functionality is implemented via the Java Script function invoked within the onclick event handler of the Cell Template. This function changes the background color of the control from the current cell, and remembers it to set its background to transparent next time this function being called.</p>

<br/>


