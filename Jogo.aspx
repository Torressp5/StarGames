<%@ Page Title="" Language="C#" MasterPageFile="~/Defaut.Master" AutoEventWireup="true" CodeBehind="Jogo.aspx.cs" Inherits="StarGame.Sitee.Jogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container Colors">

        <nav>
            <ol class="breadcrumb Colors">
                <li class="breadcrumb-item "><a href="Default.aspx">Home</a></li>
                <li class="breadcrumb-item "><a href="Catalogo.aspx">
                    <asp:Label ID="lblBreadCrumbGenero" runat="server" ></asp:Label></a></li>
                <li class="breadcrumb-item active" aria-current="page"><asp:Label ID="lblBreadCrumbAlbum" runat="server" ></asp:Label></li>
            </ol>
        </nav>

                <h1 class="text-light font-weight-light" style="font-size: 60px"><asp:Label ID="lblTitulo" runat="server"></asp:Label></h1>
            
        <div class="p-5 mb-2 bg-light text-dark row">
            <div class="rounded float-left w-50 text-center">
            <asp:Image ID="imgAlbum" runat="server" CssClass="float-left pr-1 w-50 " />
                 <div class="text-center ">
                <p><b>Plataforma: </b><asp:Label ID="lblPlataforma" runat="server"></asp:Label></p>
                <p><b>Lançamento: </b><asp:Label ID="lblLancamento" runat="server"></asp:Label></p>
                <p><b>Descrição: </b><asp:Label ID="lblDescricao" runat="server"></asp:Label></p>
            </div>
            </div>
           
        </div>

    </div>

</asp:Content>
