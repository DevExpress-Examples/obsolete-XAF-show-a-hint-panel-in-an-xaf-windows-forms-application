<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128593347/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1148)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ViewHintController.cs](./CS/WinSample.Module.Win/ViewHintController.cs) (VB: [ViewHintController.vb](./VB/WinSample.Module.Win/ViewHintController.vb))
* **[WindowHintController.cs](./CS/WinSample.Module.Win/WindowHintController.cs) (VB: [WindowHintController.vb](./VB/WinSample.Module.Win/WindowHintController.vb))**
* [Detail.cs](./CS/WinSample.Module/Detail.cs) (VB: [Detail.vb](./VB/WinSample.Module/Detail.vb))
* [Master.cs](./CS/WinSample.Module/Master.cs) (VB: [Master.vb](./VB/WinSample.Module/Master.vb))
<!-- default file list end -->
# How to show a hint panel in an XAF Windows Forms application


<p>Our FeatureCenter and AuthorizationDemo demos, which are installed with our product, contain controllers for showing hints for a list view in Web and Win applications. Since there is a need to show hints in both platforms, the structure of these controllers is complicated and may be difficult to understand. I've created a simple Windows forms example, which shows the hint panel (DevExpress.Utils.Frames.NotePanelEx), to make the concept of showing it clearer. The panel is placed on a form in the WindowHintController. This controller accesses the control to which the view is placed and adds a panel to it. So, the panel is placed near the view. Another controller - ViewHintController - demonstrates how to change the text of the added panel.<br /> We also have a more flexible example of now to accomplish this task: <a href="https://www.devexpress.com/Support/Center/p/E2690">How to: Create Information Panels</a>. It is appropriate for both Win and Web and provides better capabilities to manage the location of the additional panel, but requires templates customization. Use that example if the functionality of this example is insufficient for you.</p>
<p><strong>See Also:</strong><br /> <a href="http://documentation.devexpress.com/#Xaf/DevExpressExpressAppFrame_Templatetopic"><u>Frame.Template Property</u></a><br /> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2609"><u>Templates</u></a></p>

<br/>


