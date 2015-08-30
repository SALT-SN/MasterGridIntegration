<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container aside-xxl animated fadeInUp">
        <form data-validate="parsley" action="/Home/ShowPage" method="post" id="submitForm"
        class="submitForm panel-body wrapper-lg">
        <div class="row">
            <div class="col-sm-1">
                <h3>lmid:</h3>
            </div>
            <div class="col-sm-5">
                <input type="text" id="lmid"  name="lmid"  data-type="number" data-min="0" data-max="10000000" placeholder="please input lmid" data-required="true" data-maxlength="36" class="parsley-validated form-control input-lg" />
            </div>
            <div class="col-sm-1">
                <button type="submit" class="btn btn-primary" data-loading-text="Search..." style="margin-top:10px">
                    Search</button>
            </div>
        </div>
      
        </form>
    </div>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="UrlContent" runat="server">
    <script language="javascript" type="text/javascript">
        $(document).ready(function () {
            //表单提交
            $('.submitForm').bind('submit', function () {
                if (!$('.submitForm').parsley('validate')) {
                    $(".btn-primary").button('reset');
                    return false;
                }
            });
        });
    </script>
</asp:Content>
