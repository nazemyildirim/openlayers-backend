#pragma checksum "C:\Users\Asus\source\repos\WebApplication36\WebApplication36\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fbb88e2adaa8c476db1f9866e738d7a8f5c444c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Asus\source\repos\WebApplication36\WebApplication36\Views\_ViewImports.cshtml"
using WebApplication36;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\WebApplication36\WebApplication36\Views\_ViewImports.cshtml"
using WebApplication36.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fbb88e2adaa8c476db1f9866e738d7a8f5c444c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3756f2edcec2d55d0265aa498a045d9cc48ee361", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Point", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Polygon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "LineString", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asus\source\repos\WebApplication36\WebApplication36\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fbb88e2adaa8c476db1f9866e738d7a8f5c444c5342", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Map</title>
    <link rel=""stylesheet"" href=""https://openlayers.org/en/v3.20.1/css/ol.css"" type=""text/css"">
    <script src=""https://cdn.jsdelivr.net/gh/openlayers/openlayers.github.io@master/en/v6.5.0/build/ol.js""></script>
    <link href=""https://cdn.jsdelivr.net/npm/jspanel4@4.11.1/dist/jspanel.css"" rel=""stylesheet"">
    <script src=""https://cdn.jsdelivr.net/npm/jspanel4@4.11.1/dist/jspanel.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/jspanel4@4.11.1/dist/extensions/modal/jspanel.modal.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/jspanel4@4.11.1/dist/extensions/tooltip/jspanel.tooltip.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/jspanel4@4.11.1/dist/extensions/hint/jspanel.hint.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/jspanel4@4.11.1/dist/extensions/layout/jspanel.layout.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/jspanel4@4.11.1/dist/extensions/contextmenu/jspanel.contextmenu.j");
                WriteLiteral(@"s""></script>
    <script src=""https://cdn.jsdelivr.net/npm/jspanel4@4.11.1/dist/extensions/dock/jspanel.dock.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

    <style>
        .map {
            width: 120%;
            height: 500px;
        }

        .ol-popup {
            color: blue;
        }

        #type {
            margin-left: 2px;
            height: 18px;
            width: 114px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fbb88e2adaa8c476db1f9866e738d7a8f5c444c7903", async() => {
                WriteLiteral(@"

    <div id=""map"" class=""map""></div>
    <div id=""popup"" class=""ol-popup"">
        <a href=""#"" id=""popup-closer"" class=""ol-popup-closer""></a>
        <div id=""popup-content""></div>
    </div>

    <br>

    <textBox>Geometry Type:</textBox><select id=""type"" name=""D1"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fbb88e2adaa8c476db1f9866e738d7a8f5c444c8468", async() => {
                    WriteLiteral("Ekle");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fbb88e2adaa8c476db1f9866e738d7a8f5c444c9488", async() => {
                    WriteLiteral("Point");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fbb88e2adaa8c476db1f9866e738d7a8f5c444c10718", async() => {
                    WriteLiteral("Polygon");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fbb88e2adaa8c476db1f9866e738d7a8f5c444c11951", async() => {
                    WriteLiteral("LineString");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    </select>

    <button>Edit</button>

    &nbsp;<div>
        <br>

        <asp:GridView ID=""GridView1"" runat=""server""
                      AutoGenerateColumns=""False""
                      DataSourceID=""SqlDataSource1""
                      CellPadding=""4"" GridLines=""None"" Width=""868px"" ForeColor=""#333333"">

            <AlternatingRowStyle BackColor=""White"" ForeColor=""#284775"" />


            <Columns>

                <asp:TemplateField HeaderText=""İl"">

                    <ItemTemplate>
                        <asp:Label Text='<%#Eval(""il"")%>' runat=""server"" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID=""txtİl"" Text='<%# Eval(""il"") %>' runat=""server"" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID=""txtİlfooter"" runat=""server"" />
                    </FooterTemplate>

                </asp:TemplateField>


             ");
                WriteLiteral(@"   <asp:TemplateField HeaderText=""İlçe"">

                    <ItemTemplate>
                        <asp:Label Text='<%#Eval(""ilce"")%>' runat=""server"" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID=""txtİlçe"" Text='<%# Eval(""ilce"") %>' runat=""server"" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID=""txtİlçefooter"" runat=""server"" />
                    </FooterTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText=""Mahalle"">

                    <ItemTemplate>
                        <asp:Label Text='<%#Eval(""mahalle"")%>' runat=""server"" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID=""txtM"" Text='<%# Eval(""mahalle"") %>' runat=""server"" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <as");
                WriteLiteral(@"p:TextBox ID=""txtMfooter"" runat=""server"" />
                    </FooterTemplate>

                </asp:TemplateField>



                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button text=""Edit"" runat=""server"" CommandName=""Edit"" ToolTip=""Güncelle"" Width=""45px"" Height=""25px"" />
                        <asp:Button text=""Delete"" runat=""server"" CommandName=""Delete"" ToolTip=""Sil"" Width=""45px"" Height=""25px"" />
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

            <EditRowStyle BackColor=""#999999"" />
            <FooterStyle BackColor=""#5D7B9D"" Font-Bold=""True"" ForeColor=""White"" />
            <HeaderStyle BackColor=""#5D7B9D"" Font-Bold=""True"" ForeColor=""White"" />
            <PagerStyle BackColor=""#284775"" ForeColor=""White"" HorizontalAlign=""Center"" />
            <RowStyle BackColor=""#F7F6F3"" ForeColor=""#333333"" />
            <SelectedRowStyle BackColor=""#E2DED6"" Font-Bold=""True"" ForeColor=""#3");
                WriteLiteral(@"33333"" />
            <SortedAscendingCellStyle BackColor=""#E9E7E2"" />
            <SortedAscendingHeaderStyle BackColor=""#506C8C"" />
            <SortedDescendingCellStyle BackColor=""#FFFDF8"" />
            <SortedDescendingHeaderStyle BackColor=""#6F8DAE"" />


        </asp:GridView>



        <asp:SqlDataSource ID=""SqlDataSource1"" runat=""server"" ConnectionString=""<%$ ConnectionStrings:mapConnectionString2 %>"" SelectCommand=""SELECT * FROM [map]""></asp:SqlDataSource>




    </div>

    <script>
        var AerialWithLabels = new ol.layer.Tile({
            source: new ol.source.OSM()
        });

        var wkt = new ol.format.WKT()

        var middle = ol.proj.fromLonLat([35.2433, 38.9637]);


        var view = new ol.View({
            center: middle,
            zoom: 6
        });


        var map = new ol.Map({
            target: 'map',
            layers: [AerialWithLabels],
            view: view




        });

        var features = new ol.Collectio");
                WriteLiteral(@"n();

        var source = new ol.source.Vector({ features: features });

        var vectorLayerM = new ol.layer.Vector({
            source: source,

            style: new ol.style.Style({
                fill: new ol.style.Fill({
                    color: 'rgba(255, 255, 255, 0.2)'
                }),
                stroke: new ol.style.Stroke({
                    color: '#ffcc33',
                    width: 2
                })

            })
        });

        map.addLayer(vectorLayerM);

        var vectorLayerK = new ol.layer.Vector({
            source: source,
            style: new ol.style.Style({

                image: new ol.style.Circle({
                    radius: 5,
                    fill: new ol.style.Fill({
                        color: '#ffcc33'
                    })
                })

            })

        });

        map.addLayer(vectorLayerK);


        var modify = new ol.interaction.Modify({
            features: features,

   ");
                WriteLiteral(@"         deleteCondition: function (event) {
                return ol.events.condition.shiftKeyOnly(event) &&
                    ol.events.condition.singleClick(event);
            }
        });
        map.addInteraction(modify);


        var draw;
        var draw1;
        var draw2;
        var typeSelect = document.getElementById('type');


        function addInteractionP() {
            draw = new ol.interaction.Draw({
                features: features,
                type: 'Point'
            });
            map.addInteraction(draw);

        }

        function addInteractionPoly() {
            draw1 = new ol.interaction.Draw({
                features: features,
                type: 'Polygon'
            });
            map.addInteraction(draw1);

        }

        function addInteractionLine() {
            draw2 = new ol.interaction.Draw({
                features: features,
                type: 'LineString'
            });
            map.addInteracti");
                WriteLiteral(@"on(draw2);
        }


        var modify1 = new ol.interaction.Modify({
            source: source
        });
        map.addInteraction(modify1);


        var snap;

        function addInteractions() {
            addInteractionPoly();
            addInteractionP();
            addInteractionLine();

            snap = new ol.interaction.Snap({
                source: source
            });

            map.addInteraction(snap);
        }

        var data;
        var coords;

        var span = document.getElementsByClassName(""close"")[0];


        typeSelect.onchange = function () {

            if (typeSelect.value === 'Point') {
                map.removeInteraction(draw);
                map.removeInteraction(draw1);
                map.removeInteraction(draw2);
                addInteractionP();

                draw.on('drawend', function (e) {

                    var currentFeature = e.feature;

                    coords = currentFeature.getGeometry().");
                WriteLiteral(@"getCoordinates();
                    draw.setActive(false);

                    jsPanel.create({
                        id: ""point-panel"",

                        headerTitle: 'Point Ekle',
                        position: 'center-top 0 58',
                        contentSize: '300 250',
                        content: 'İl: <br><input id=""il"" type=""text""/><br> <br> İlçe: <br ><input id=""ilce"" type=""text""/> <br><br> Mahalle: <br ><input id=""mahalle"" type=""text""/>     <br><br><br><button style=""height:50px;width:60px"" id=""kapi_kaydet"" class=""btn btn-success"">Kaydet</button>',
                        callback: function () {
                            this.content.style.padding = '20px';
                        },
                        onclosed: function () {
                            source.removeFeature(currentFeature);
                        }
                    });
                });


            } else if (typeSelect.value === 'Polygon') {


                map.removeIn");
                WriteLiteral(@"teraction(draw1);
                map.removeInteraction(draw);
                map.removeInteraction(draw2);
                addInteractionPoly();


                draw1.on('drawend', function (e) {


                    var currentFeature = e.feature;

                    coords = currentFeature.getGeometry().getCoordinates()[0];
                    draw1.setActive(false);

                    jsPanel.create({
                        id: ""polygon-panel"",
                        headerTitle: 'Polygon Ekle',
                        position: 'center-top 0 58',
                        contentSize: '300 250',
                        content: 'İl: <br><input id=""il"" type=""text""/><br> <br> İlçe: <br ><input id=""ilce"" type=""text""/> <br><br> Mahalle: <br ><input id=""mahalle"" type=""text""/>     <br><br><br><button style=""height:50px;width:60px"" id=""kapi_kaydet"" class=""btn btn-success"">Kaydet</button>',
                        callback: function () {

                            this.content.styl");
                WriteLiteral(@"e.padding = '20px';
                        },
                        onclosed: function () {
                            source.removeFeature(currentFeature);
                        }
                    });

                });


            } else if (typeSelect.value === 'LineString') {
                map.removeInteraction(draw);
                map.removeInteraction(draw1);
                map.removeInteraction(draw2);
                //  map.removeInteraction(snap);
                addInteractionLine();

                draw2.on('drawend', function (e) {


                    var currentFeature = e.feature;

                    coords = currentFeature.getGeometry().getCoordinates()[0];
                    draw2.setActive(false);

                    jsPanel.create({
                        id: ""line-panel"",

                        headerTitle: 'Line String Ekle',
                        position: 'center-top 0 58',
                        contentSize: '300 250',
      ");
                WriteLiteral(@"                  content: 'İl: <br><input id=""il"" type=""text""/><br> <br> İlçe: <br ><input id=""ilce"" type=""text""/> <br><br> Mahalle: <br ><input id=""mahalle"" type=""text""/>     <br><br><br><button style=""height:50px;width:60px"" id=""kapi_kaydet"" class=""btn btn-success"">Kaydet</button>',
                        callback: function () {
                            this.content.style.padding = '20px';
                        },
                        onclosed: function () {
                            source.removeFeature(currentFeature);
                        }
                    });

                });

            }
        };

    </script>






");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591