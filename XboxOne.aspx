<%@ Page Title="" Language="C#" MasterPageFile="~/Defaut.Master" AutoEventWireup="true" CodeBehind="XboxOne.aspx.cs" Inherits="StarGame.Sitee.XboxOne" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <!--Carrosel-->
          <!--Carrosel-->
        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="d-block w-100" src="Image/Banners/banner-xbox-one_01.png" alt="First slide">
                </div>
                <div class="carousel-item">
                    <img class="d-block w-100" src="Image/Banners/banner-xbox-one_02.png" alt="Second slide">
                </div>
                <div class="carousel-item">
                    <img class="d-block w-100" src="Image/Banners/xbox-1-banner-_03.png" alt="Third slide">
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    <br />
    <hr />

    <div class="container Colors">

       <nav>
            <ol class="breadcrumb Colors">
                <li class="breadcrumb-item "><a href="Default.aspx">Home</a></li>
                <li class="breadcrumb-item active" aria-current="page">Xbox One</li>
            </ol>
        </nav>
        <h1 class="text-light font-weight-light" style="font-size: 60px">Xbox One</h1>


        <div class="card-columns card-columns-star" >

            <asp:Repeater ID="rptJogos" runat="server">
                <ItemTemplate>
                    <div class="card card-star"  >
                        <a href="Jogo.aspx?id=<%# DataBinder.Eval(Container.DataItem,"IdJogo") %>">
                            <img class="card-img-top" src="<%# DataBinder.Eval(Container.DataItem, "UrlImagemAlbum").ToString().Replace(@"C:\Users\HomePc\Desktop\StarGames\StarGame.Sitee\Image", "Image") %>" alt="Card image cap">
                        </a>
                        <div class="card-body">
                            <a href="Jogo.aspx?id=<%# DataBinder.Eval(Container.DataItem,"IdJogo") %>">
                                <h5 class="card-title"><%# DataBinder.Eval(Container.DataItem,"NmJogo") %></h5>
                            </a>
                            <p class="card-text"><%# DataBinder.Eval(Container.DataItem,"DescGenero") %> -  <%# DataBinder.Eval(Container.DataItem,"TipoDeJogo") %></p>
                            <span class="badge badge-info"><%# DataBinder.Eval(Container.DataItem,"DtLancamento") %></span>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>     
    <hr />
    <br />
    <div class="carousel-inner">
        <div class="carousel-item active">
                    <img class="d-block w-100" src="Image/Banners/xboxBanner.png" alt="First slide">
        </div>
    </div>

        <br />
     <br />
     <br />

</asp:Content>
