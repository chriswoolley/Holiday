#pragma checksum "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "773038a0b1aa2d6edefea77cb590f5e04b9a57e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Scheduler), @"mvc.1.0.view", @"/Views/Home/Scheduler.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Scheduler.cshtml", typeof(AspNetCore.Views_Home_Scheduler))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb;

#line default
#line hidden
#line 2 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb.Models;

#line default
#line hidden
#line 3 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb.ViewModels;

#line default
#line hidden
#line 4 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb.Models.Interface;

#line default
#line hidden
#line 6 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb.Controllers;

#line default
#line hidden
#line 10 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#line 1 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"773038a0b1aa2d6edefea77cb590f5e04b9a57e8", @"/Views/Home/Scheduler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08f9652131acdbd25428686e41c39b44760ec267", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Scheduler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Appointment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(213, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 9 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
  
    bool isUserLoggedIn = ViewBag.Users != null;
    string currentID = runtime.currentUserId;

#line default
#line hidden
            BeginContext(323, 62, true);
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    var currentUserId = \'");
            EndContext();
            BeginContext(386, 21, false);
#line 16 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
                    Write(runtime.currentUserId);

#line default
#line hidden
            EndContext();
            BeginContext(407, 26, true);
            WriteLiteral("\';\r\n    var isSignedIn = \'");
            EndContext();
            BeginContext(435, 30, false);
#line 17 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
                  Write(SignInManager.IsSignedIn(User));

#line default
#line hidden
            EndContext();
            BeginContext(466, 29, true);
            WriteLiteral("\';\r\n    var adminSignedIn = \'");
            EndContext();
            BeginContext(497, 56, false);
#line 18 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
                     Write(SignInManager.IsSignedIn(User) && User.IsInRole("Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(554, 109, true);
            WriteLiteral("\';\r\n</script>\r\n\r\n<div class=\"row\">\r\n\r\n    <h2></h2>\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n    ");
            EndContext();
            BeginContext(664, 9, false);
#line 30 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
Write(currentID);

#line default
#line hidden
            EndContext();
            BeginContext(673, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(681, 2275, false);
#line 33 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
Write(Html.DevExtreme().Scheduler()
.ID("scheduler")
.DataSource(Model)
.TextExpr("Description")
.StartDateExpr("StartDate")
.EndDateExpr("EndDate")
//.Disabled($isSignedIn)
//                                                                    .Views(new SchedulerViewType[] { SchedulerViewType.Day, SchedulerViewType.TimelineMonth, SchedulerViewType.WorkWeek, SchedulerViewType.Week, SchedulerViewType.Agenda })
.Views(new SchedulerViewType[] { SchedulerViewType.Week })
.CurrentView(SchedulerViewType.Week)
.CurrentDate(new DateTime(2019, 3, 7))
.FirstDayOfWeek(FirstDayOfWeek.Sunday)

.OnAppointmentClick("SetProtection")
.OnAppointmentDblClick("SetProtection")

.Option("editing.allowResizing", false)
.Option("editing.allowDragging", false)
.OnAppointmentAdded("InsertData")

.StartDayHour(9)
.EndDayHour(18)
.CellDuration(120)
.MaxAppointmentsPerCell(5)
.OnAppointmentFormOpening("appointmentForm_created")


.Resources(res =>
{
    res.Add()
    .FieldExpr("StartPeriod")
    .AllowMultiple(false)
    .Label("Start Period")
    .DataSource
    (new object[] {

new { id = 0, text = "Morning" },
new { id = 1, text = "Afternoon" }});

    res.Add()
    .FieldExpr("EndPeriod")
    .AllowMultiple(false)
    .Label("End Period")
    .DataSource
    (new object[] {
new { id = 0, text = "Morning"},
new { id = 1, text = "Afternoon"}});

    res.Add()
    .FieldExpr("StatusKey")
    .AllowMultiple(false)
    .Label("Status")
    .DataSource
    (new object[] {
new { id = 0, text = "Requested"},
new { id = 1, text = "Confirmed"},
new { id = 2, text = "Denied"}
                                                                                                                                                                                                                                                });

    res.Add()
    .FieldExpr("UserID")
    .AllowMultiple(false)
    .ColorExpr("colorHighlight")
    .Label("remove me")
    .DataSource(userManager.Users.ToList()).DisplayExpr("UserName").ValueExpr("Id");

    res.Add()
    .FieldExpr("UserID")
    .AllowMultiple(false)
    .Label("User")
    .DataSource(userManager.Users.ToList()).DisplayExpr("UserName").ValueExpr("Id");

}
).Height(580)
);

#line default
#line hidden
            EndContext();
            BeginContext(2957, 18, true);
            WriteLiteral("\r\n\r\n    currentid ");
            EndContext();
            BeginContext(2976, 9, false);
#line 109 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
         Write(currentID);

#line default
#line hidden
            EndContext();
            BeginContext(2985, 26, true);
            WriteLiteral("\r\n    signed in and admin ");
            EndContext();
            BeginContext(3013, 56, false);
#line 110 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
                    Write(SignInManager.IsSignedIn(User) && User.IsInRole("Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(3070, 57, true);
            WriteLiteral("\r\n</div>\r\n\r\n<script>\r\n\r\n    var HolidayAppointmentData = ");
            EndContext();
            BeginContext(3128, 60, false);
#line 115 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
                            Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model)));

#line default
#line hidden
            EndContext();
            BeginContext(3188, 21, true);
            WriteLiteral(";\r\n\r\n    var Users = ");
            EndContext();
            BeginContext(3210, 72, false);
#line 117 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
           Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(userManager.Users)));

#line default
#line hidden
            EndContext();
            BeginContext(3282, 8339, true);
            WriteLiteral(@";

//    var test1 = $runtime.currentUserId;


    function getSchedulerInstance() {
        return $(""#scheduler"").dxScheduler(""instance"");
    }

    function getAppointmentById(id) {
        return DevExpress.data.query(HolidayAppointmentData)
            .filter(""AppointmentId"", id)
            .toArray()[0]
    }


    function SetProtection(data) {
        scheduler = $(""#scheduler"").dxScheduler(""instance"");
    }


    function appointmentForm_created(data) {
        var form = data.form,
            HolidayAppointment = getAppointmentById(data.appointmentData.AppointmentId) || {},
            startDate = data.appointmentData.StartDate,
            endDate = data.appointmentData.EndDate,
            users = Users;


        // set userId depending on insert or edit
        SelectUserId = """";
        if (HolidayAppointment.AppointmentId == undefined) {
            SelectUserId = currentUserId;
            SelectTypeId = 0;
        }
        else {
            SelectUs");
            WriteLiteral(@"erId = HolidayAppointment.UserID;
            SelectTypeId = HolidayAppointment.StatusKey;
        }



        ReadOnlyStatus = !adminSignedIn;
        //ViewOnly = isSignedIn;
        ViewOnly = false;


        //showToast2(""ReadOnlyStatus:"" + ReadOnlyStatus);
//        showToast2(""ReadOnlyStatus:"" + ReadOnlyStatus);
        showToast2(""currentUserId:"" + currentUserId + "" isSignedIn:"" + isSignedIn + "" adminSignedIn:"" + adminSignedIn);
        //showToast2(""SelectUserId:"" + SelectUserId + "" test2:"" + currentUserId + "" HolidayAppointment.UserID:"" + HolidayAppointment.UserID + "" SelectTypeId:"" + SelectTypeId);



        form.option(

            ""items"", [
                {
                    dataField: ""UserID"",
                    editorType: ""dxSelectBox"",
                    name: ""userEditor"",
                    editorOptions: {
                        dataSource: Users,
                        displayExpr: ""UserName"",
                        valueExpr: ""Id"",
             ");
            WriteLiteral(@"           value: SelectUserId,
//                        readOnly: ReadOnlyStatus
                }
            }
            ,
            {
                dataField: ""StartDate"",
                editorType: ""dxDateBox"",
                name: ""startDateEditor"",
                editorOptions: {
                    value: startDate,
                    width: ""100%"",
                    type: ""date"",
                    editorOptions: { format:""date""},
                    onValueChanged: function (args) {
                        startDate = args.value;
                    }
                }
                }
            ,
            {
                dataField: ""StartPeriod"",
                editorType: ""dxSelectBox"",
                editorOptions: {
                    dataSource: [{ ""ID"": 0, ""periodName"": ""Morning"" }, { ""ID"": 1, ""periodName"": ""Afternoon"" }],
                    valueExpr: ""ID"",
                    displayExpr: ""periodName"",
                    value: HolidayApp");
            WriteLiteral(@"ointment.StartPeriod,
                    onValueChanged: function (args) {
                        var startDate = data.appointmentData.StartDate;
                        var startEditor = form.getEditor(""startDate"");
                        var year = startDate.getFullYear();
                        var month = startDate.getMonth();
                        var day = startDate.getDate();
                        if (args.value === 0) {
                            data.appointmentData.startDate = new Date(year, month, day, 9, 0, 0, 0);

                        }
                        else {
                            data.appointmentData.startDate = new Date(year, month, day, 13, 0, 0, 0);
                        }
                        var testDate = data.appointmentData.startDate;
                        form.getEditor(""startDateEditor"").option(""value"", testDate);
                        showToast(""Holiday start time set to "" + testDate, testDate, ""info"");
                    }
       ");
            WriteLiteral(@"         }
            }

            ,
            {
                dataField: ""EndDate"",
                editorType: ""dxDateBox"",
                name: ""endDateEditor"",
                editorOptions: {
                    value: endDate,
                    width: ""100%"",
                    type: ""datetime"",
                    onValueChanged: function (args) {
                    }
                }
            }

                ,
                {
                    dataField: ""EndPeriod"",
                    editorType: ""dxSelectBox"",
                    helpText: ""when it ends"",
                    editorOptions: {
                        dataSource: [{ ""ID"": 0, ""periodName"": ""Morning"" }, { ""ID"": 1, ""periodName"": ""Afternoon"" }],
                        valueExpr: ""ID"",
                        displayExpr: ""periodName"",
                        value: HolidayAppointment.EndPeriod,
                        onValueChanged: function (args) {
                            var endD");
            WriteLiteral(@"ate = data.appointmentData.EndDate;
                            var startEditor = form.getEditor(""startDate"");
                            var year = startDate.getFullYear();
                            var month = startDate.getMonth();
                            var day = startDate.getDate();
                            if (args.value === 0) {
                                data.appointmentData.endDate = new Date(year, month, day, 13, 0, 0, 0);

                            }
                            else {
                                data.appointmentData.endDate = new Date(year, month, day, 17, 0, 0, 0);
                            }
                            var testDate = data.appointmentData.endDate;
                            form.getEditor(""endDateEditor"").option(""value"", testDate);
                            showToast(""Holiday finsh time set to "" + testDate, testDate, ""info"");
                        }
                    }
                }

            ,
            {");
            WriteLiteral(@"
                dataField: ""StatusKey"",
                editorType: ""dxSelectBox"",
                editorOptions: {
                    dataSource: [{ ""ID"": 0, ""Status"": ""Requested"" }, { ""ID"": 1, ""Status"": ""Granted"" }, { ""ID"": 2, ""Status"": ""Denied"" }, { ""ID"": 3, ""Status"": ""Delayed"" }],
                    valueExpr: ""ID"",
                    displayExpr: ""Status"",
                    value: SelectTypeId,
  //                  readOnly: ReadOnlyStatus
                }
                }

                ,
                {
                    dataField: ""Text"",
                    editorType: ""dxTextArea"",
                    //height: ""80px"",
                    editorOptions: {
                        valueExpr: ""Text"",
                        displayExpr: ""Text"",
                        value: HolidayAppointment.Text
                    }
                }
            ]);
    }

    function showToast(event, value, type) {
        DevExpress.ui.notify(event + "" \"""" + value + ""\""""");
            WriteLiteral(@" + "" task"", type, 800);
    }

    function showToast2(value) {

        DevExpress.ui.notify(value, ""info"", 3600);
    }

    function InsertData(e) {

        var data = { // to be replaced with form values
//            AppointmentId: e.appointmentData.AppointmentId,
            AppointmentId: 0,
            Text: e.appointmentData.Text,
            Description: e.appointmentData.Description,
            StartDate: e.appointmentData.StartDate,
            EndDate: e.appointmentData.EndDate,
            AllDay: e.appointmentData.AllDay,
            RecurrenceRule: e.appointmentData.RecurrenceRule,
            DepartmentID: e.appointmentData.DepartmentID,
            StatusKey: e.appointmentData.StatusKey,
            UserID: e.appointmentData.UserID,
            HolidaysTaken: e.appointmentData.HolidaysTaken,
            Duration: e.appointmentData.Duration,
            StartPeriod: e.appointmentData.StartPeriod,
            EndPeriod: e.appointmentData.EndPeriod
        };

    ");
            WriteLiteral("    //alert(JSON.stringify(data));\r\n        //console.log(JSON.stringify(data));\r\n\r\n        $.ajax({\r\n            type: \"POST\",\r\n            url: \"");
            EndContext();
            BeginContext(11622, 26, false);
#line 335 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Scheduler.cshtml"
             Write(Url.Action("Post", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(11648, 681, true);
            WriteLiteral(@""",
            contentType: ""application/json"",
            dataType: ""json"",
            data:  JSON.stringify(data),
            success: function (response) {
                showToast(""Insert new appointment"", """", """");
//                alert('done');
            },
            error: function (response) {
                alert(response);
            }
        });
    }

    function setDataSource(e) {
        //this one fies the event
        //$.post(""Home/WebAPIService"");
        alert(1);
        //var scheduler = $(""#scheduler"").dxScheduler(""getDataSource"");
        var scheduler = $(""#scheduler"");
        alert(2);
        alert(scheduler);
");
            EndContext();
            BeginContext(12428, 451, true);
            WriteLiteral(@"//        $.post(""ApiControllers/SchedulerData/Index"");
//        $.post(""SchedulerData/Index"");
        //Controller(""SchedulerData"").GetJSONJQuery()
        //AppointmentData = dataSource
    }

    function SelectAppointment(e) {
      alert(dataSource.typeof);
    }

    function getTrue() {
        return false
    }

    function getSchedulerInstance() {
        return $(""#scheduler"").dxScheduler(""instance"");
    }
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRuntime runtime { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<HolidayUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<HolidayUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
