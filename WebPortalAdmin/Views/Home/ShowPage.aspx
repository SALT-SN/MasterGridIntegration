<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%if (ViewData["lmname"] == "")
      { %>
    No data!
    <% }
      else
      { %>
    <div id="firstpane" class="menu_list">
        <p class="menu_head current" onclick=dess()>
            Description &nbsp&nbsp&nbsp
            <span class="glyphicon glyphicon-thumbs-up"></span>
            <%= ViewData["Like"]%>
        </p>
        <div style="display: block" class="menu_body">
            <div style="text-align: left; font-weight: bold; font-size: 20px;padding:10px;">
                <div style="display: inline">
                </div>
                <div style="display: inline">
                    <%= ViewData["lmname"]%>
                </div>
            </div>
            <div style="text-align: left;padding:10px">
                <%= ViewData["lmdes"]%>
            </div>
        </div>

        <p class="menu_head" onclick=exa();>
            Example</p>
        <div style="display: none" class="menu_body">
            <div style="text-align: left; padding: 15px;">
                <%= ViewData["edes"]%>
                <%-- <%if (ViewData["edes"].ToString() != "")
                  { %>
                <input type="button" style="display: inline-block; outline: none; cursor: pointer;
                    text-align: center; text-decoration: none; font: 12px/60% Arial, Helvetica, sans-serif;
                    padding: .5em 2em .55em; text-shadow: 0 1px 1px rgba(0,0,0,.3); -webkit-border-radius: .5em;
                    -moz-border-radius: .5em; border-radius: .5em; -webkit-box-shadow: 0 1px 2px rgba(0,0,0,.2);
                    -moz-box-shadow: 0 1px 2px rgba(0,0,0,.2); box-shadow: 0 1px 2px rgba(0,0,0,.2);"
                    value="Show example" onclick="ShowAnsource(), lclose('ansource')" />
                <%} %>--%>
            </div>
        </div>
        <p class="menu_head" onclick=tes()>
            Test</p>
        <div style="display: none" class="menu_body">
            <div id="TestAttributes" style="text-align: left;">
                    <%if (ViewData["QuestionList"] != null)
                      {
                          List<Aspx.Model.QuestionView> list = ViewData["QuestionList"] as List<Aspx.Model.QuestionView>;

                          for (int i = 1; i <= list.Count; i++)
                          {
                              var num = i;
                              var lmid = list[i - 1].lmid;
                              var qqid = list[i - 1].qid;
                              var title = list[i - 1].question_des;
                              var optionlist = list[i - 1].OptionList;
                              var answer = list[i - 1].answer_choice;
                         %>
                                <table  style=" padding:20px; width:100%" name="<%=lmid%>" answer="<%=answer%>" id="<%=num%>">
                                     <tr align="left" style="background-color:Silver">
                        <td>
                          <p> <font style="font-size:16px; font-weight:600"> Q<%=num%></font>&nbsp; &nbsp;&nbsp; <%=title%></p>
                        </td>
                        <td>
                            <input id="<%=lmid%>" type="text" value="<%=answer%>" style="display:none"/>
                        </td>
                    </tr>                
                                     <tr>
                                          <td>
                                                    <table style="margin-left:50px;" id="Answertable<%=num%>>">
                                                             <%
                                                      List<Aspx.Model.ModOption> OptionList = optionlist;
                                                      for (int a = 0; a < OptionList.Count; a++)
                                                      {
                                                          var smalltitle = OptionList[a].choice;
                                                          var qid = OptionList[a].qid;
                                                           %> 
                                                           <tr>
                                                            <td>
                                                             <input type="radio" value="<%=smalltitle%>" name="<%=qid %>" /><%=smalltitle%>
                                                              </td>
                                                        </tr>
                                                     <%  }
                                                         %>
                                                    </table>
                                                </td>
                                        <td>
                                        </td>
                                    </tr>
                                     <tr id="ErrorTr<%=num%>" style="display:none" align="left">
                                            <td class="label label-danger">
                                             Wrong answer, please try again.
                                            </td>
                                            <td  class="label label-success">
                                             Correct answer:<%=answer%>
                                            </td>
                                           </tr>
                                    <tr id="Right<%=num%>" style="display:none" align="left">
                                            <td  class="label label-success">
                                              Correct!
                                            </td>
                                           </tr>
                                     </table>

                                            <%  
                             }  
                        %>
                            <hr style="background-color:Green" />
                             <div style="text-align: center;">
                                <button type="button" id="submitTest" class="btn btn-primary" data-loading-text="Search..." style="margin-top:10px">
                                    Submit Test</button>
                             </div>

                     <%     }
                      else { %>
                      No data
                      
                  <%  } %>
               
            </div>
            
        </div>
    </div>
    <%} %>

                    <asp:Panel ID="Panel1" runat="server" Height="70px">
        </asp:Panel>


              <i id="p1" style="position: fixed; bottom:0px; width: 100%; height: 50px; left: 6px; background:white; color: #000000; font-style: italic;">
        &nbsp; Do you like this lesslet?&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <button ID="hide" type="button" onclick="like()" style="color: #000000; font-style: normal">Like</button>
                    &nbsp;&nbsp;
            <button ID="hide1" type="button" onclick=dislike()>Dislike</button> 
                    &nbsp;&nbsp;
            <button ID="hide2" type="button" onclick=nocomment()>No comment</button>
                         </i>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="UrlContent" runat="server">
    <link href="../Content/accordion/css/zzsc.css" rel="stylesheet" type="text/css" />
    <script src="../Content/accordion/js/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#firstpane .menu_body:eq(0)").show();
            $("#firstpane p.menu_head").click(function () {
                $(this).addClass("current").next("div.menu_body").slideToggle(300).siblings("div.menu_body").slideUp("slow");
                $(this).siblings().removeClass("current");
            });
            $("#secondpane .menu_body:eq(0)").show();
            $("#secondpane p.menu_head").mouseover(function () {
                $(this).addClass("current").next("div.menu_body").slideDown(500).siblings("div.menu_body").slideUp("slow");
                $(this).siblings().removeClass("current");
            });


            $("#submitTest").click(function (val) {
                
               // top.bootbox.confirm("Sure To Submit?", function (result) {
                   // document.getElementById("ansource");
                    //if (result) {
                        var attributeTable = $("#TestAttributes").find('table');
                        var RightNum = 0;
                        var lmid = 0;
                        var total = 0;
                        attributeTable.each(function () {
                            var answer = $(this).attr('answer'); //LL answer
                            if ($(this).attr('name') != null) {
                                lmid = $(this).attr('name');
                            }
                            //get LL
                            var id = $(this).attr('id'); //LL primary key
                            var AnswertableTable = $(this).find('table input');
                            var length = AnswertableTable.length;
                            var checked = 0;
                            var choseAnsur = '';
                            AnswertableTable.each(function () {
                                if ($(this)[0].checked == true) {
                                    total++;
                                    choseAnsur = $(this)[0].value;
                                    if (choseAnsur != answer) {
                                        $("#ErrorTr" + id).attr("style", "display:block");
                                    }
                                    else {
                                        $("#Right" + id).attr("style", "display:block");
                                        RightNum++;
                                        
                                    }
                                }
                                else {
                                    checked++;  
                                }
                                
                            });
                            if (checked == length) {
                                $("#ErrorTr" + id).attr("style", "display:block");
                            }
                        });
                        RightNum = Math.round(RightNum * 100 / total);
                        //submit result
                        $.ajax({
                            url: '/SALT_MG2/Home/SubmitTest?date=' + new Date(),
                            async: false,
                            dataType: "json",
                            data: { RightNum: RightNum, lmid: lmid },
                            success: function (result) {
                                //top.bootbox.alert("Delete!");
                                //Refrush();
                            },
                            error: function () {
                            }
                        });
                    
                
            });
        });
    </script>

        <script type="text/javascript">
        $(document).ready(function () {
            $("#hide").click(function () {
                $.ajax({
                    type: 'GET', //i changed this because it actually probably better suits the nature of your request
                    url: '../Home/Like',
                    cache: false, //(probably)
                    dataType: 'json', //(probably)

                });
                $("#p1").hide();
                
            });
            $("#hide1").click(function () {
                $.ajax({
                    type: 'GET', //i changed this because it actually probably better suits the nature of your request
                    url: '../Home/DisLike',
                    cache: false, //(probably)
                    dataType: 'json', //(probably)

                });
                $("#p1").hide();
            });
            $("#hide2").click(function () {
                $.ajax({
                    type: 'GET', //i changed this because it actually probably better suits the nature of your request
                    url: '../Home/NoComment',
                    cache: false, //(probably)
                    dataType: 'json', //(probably)

                });
                $("#p1").hide();
            });
        });
</script>

    <script language="javascript" type="text/javascript">
        function ShowAnsource() {
            document.getElementById("ansource").setAttribute("style", "display:block");
            /*var ad = document.getElementById("ansource")
            if (ad.style.display == "inline")
            {
            ad.setAttribute("style", "display:none");
            }
            else {
            ad.setAttribute("style", "display:inline");
            }
            */
        }

        function lclose(str) {
            var ad = document.getElementById(str)
            ad.style.display = (ad.style.display == 'none') ? '' : 'inline';
        }
    </script>

    <script type="text/javascript">
        function exa() {
            $.ajax({
                type: 'GET', //i changed this because it actually probably better suits the nature of your request
                url: '../Home/Example',
                cache: false, //(probably)
                dataType: 'json', //(probably)
                //data: dummy,  //json object with any data you might want to use
                //success: function (result) {
                    //alert("Succeed");
                    //you can also update your divs here with the `result` object, which contains whatever your method returns
                
            });
        }
</script>

    <script type="text/javascript">
        function tes() {
            $.ajax({
                type: 'GET', //i changed this because it actually probably better suits the nature of your request
                url: '../Home/Test',
                cache: false, //(probably)
                dataType: 'json', //(probably)
                //data: dummy,  //json object with any data you might want to use
                //success: function (result) {
                //alert("Succeed");
                //you can also update your divs here with the `result` object, which contains whatever your method returns

            });
        }
</script>

    <script type="text/javascript">
        function dess() {
            $.ajax({
                type: 'GET', //i changed this because it actually probably better suits the nature of your request
                url: '../Home/Dess',
                cache: false, //(probably)
                dataType: 'json', //(probably)
                //data: dummy,  //json object with any data you might want to use
                //success: function (result) {
                //alert("Succeed");
                //you can also update your divs here with the `result` object, which contains whatever your method returns

            });
        }
</script>
</asp:Content>
