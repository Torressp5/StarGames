<%@ Page Title="" Language="C#" MasterPageFile="~/Defaut.Master" AutoEventWireup="true" CodeBehind="Confirmacao.aspx.cs" Inherits="StarGame.Sitee.Confirmacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container Colors">

        <nav>
            <ol class="breadcrumb Colors">
                <li class="breadcrumb-item "><a href="Default.aspx">Home</a></li>
                <li class="breadcrumb-item "><a href="Cadastro.aspx">Cadastre-se</a></li>
                <li class="breadcrumb-item active" aria-current="page">Confirmação</li>
            </ol>
        </nav>

        <h1 class="text-light font-weight-light" style="font-size: 60px">Cadastro de Usuário</h1>
        <div class="p-5 mb-2 bg-light text-dark">
            <p class="text-sm-start">
                Parabéns! Seu Cadastro foi efetuado com Sucesso.<br />
                Agora você faz parte do seleto grupo de Usuário da StarGames.<br />
                Sempre que tivemos Novidades e etc. você sera um dos primeiros a receber!
            </p>
        </div>
    </div>
</asp:Content>
