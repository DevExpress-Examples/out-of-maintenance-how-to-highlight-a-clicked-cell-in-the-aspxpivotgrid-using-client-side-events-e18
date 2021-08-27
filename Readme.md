<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1830)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Q154045/Default.aspx) (VB: [Default.aspx](./VB/Q154045/Default.aspx))
* [Default.aspx.cs](./CS/Q154045/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Q154045/Default.aspx.vb))
<!-- default file list end -->
# How to highlight a clicked cell in the ASPxPivotGrid using client-side events
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1830/)**
<!-- run online end -->


<p>This example demonstrates how to highlight a cell if the user clicks on it using client side events. The previously clicked cell background reverts to its normal.</p>


<h3>Description</h3>

<p>This functionality is implemented via the Java Script function invoked within the onclick event handler of the Cell Template. This function changes the background color of the control from the current cell, and remembers it to set its background to transparent next time this function being called.</p>

<br/>


