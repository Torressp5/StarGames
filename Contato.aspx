<%@ Page Title="" Language="C#" MasterPageFile="~/Defaut.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="StarGame.Sitee.Contato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container Colors">

        <nav>
            <ol class="breadcrumb Colors">
                <li class="breadcrumb-item "><a href="Default.aspx">Home</a></li>
                <li class="breadcrumb-item active" aria-current="page">Contato</li>
            </ol>
        </nav>

        <h1 class="text-light font-weight-light" style="font-size: 60px">Fale Conosco</h1>

        <br />


        <asp:Label runat="server" Text="Nome" AssociatedControlID="txtNome" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" MaxLength="100" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvNome" ControlToValidate="txtNome" ErrorMessage="Campo nome é Obrigatótio" ForeColor="Yellow" />
        <br />
        <asp:Label runat="server" Text="E-mail" AssociatedControlID="txtEmail" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" MaxLength="100" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ControlToValidate="txtEmail" ErrorMessage="Campo E-mail é Obrigatótio" ForeColor="Yellow" />

              <asp:RegularExpressionValidator runat="server" ID="gevEmailValido" ControlToValidate="txtEmail"
                  ErrorMessage="O E-mail é invalido" ForeColor="Yellow" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />

        <br />
        <asp:Label runat="server" Text="Telefone" AssociatedControlID="txtTelefone" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtTelefone" CssClass="form-control phone_with_ddd " MaxLength="20" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvTelefone" ControlToValidate="txtTelefone" ErrorMessage="Campo Telefone é Obrigatótio" ForeColor="Yellow" />
        <br />
        <asp:Label runat="server" Text="Mensagem" AssociatedControlID="txtMensagem" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtMensagem" CssClass="form-control " Width="50%" Height="120" TextMode="MultiLine" />
        <asp:RequiredFieldValidator runat="server" ID="rfvMensagem" ControlToValidate="txtMensagem" ErrorMessage="Campo Mensagem é Obrigatótio" ForeColor="Yellow" />
        
  
        <br /> <br />
        <asp:Button runat="server" ID="BtnEnviar" Text="Enviar" CssClass="btn btn-secondary" OnClick="BtnEnviar_Click" />

        <br /> <br />
        <asp:Label runat="server" ID="lblMensagem" CssClass="text-light lead" />

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

    </div>

</asp:Content>
