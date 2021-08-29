<%@ Page Title="" Language="C#" MasterPageFile="~/Defaut.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="StarGame.Sitee.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container Colors">

        <nav>
            <ol class="breadcrumb Colors">
                <li class="breadcrumb-item "><a href="Default.aspx">Home</a></li>
                <li class="breadcrumb-item active" aria-current="page">Cadastre-se</li>
            </ol>
        </nav>

        <h1 class="text-light font-weight-light" style="font-size: 60px">Cadastro de Usuários</h1>

        <br />
        <asp:Label runat="server" Text="Nome" AssociatedControlID="txtNome" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" MaxLength="100" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvNome" ControlToValidate="txtNome" ErrorMessage="Campo nome é Obrigatótio" ForeColor="Yellow" />
            <br />
        <asp:Label runat="server" Text="CPF" AssociatedControlID="txtCpf" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtCpf" CssClass="form-control cpf" MaxLength="14" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvCpf" ControlToValidate="txtCpf" ErrorMessage="Campo CPF é Obrigatótio" ForeColor="Yellow" />
            <br />
        <asp:Label runat="server" Text="E-mail" AssociatedControlID="txtEmail" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" MaxLength="100" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ControlToValidate="txtEmail" ErrorMessage="Campo E-mail é Obrigatótio" ForeColor="Yellow" />
            <br />
        <asp:Label runat="server" Text="Telefone" AssociatedControlID="txtTelefone" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtTelefone" CssClass="form-control phone_with_ddd " MaxLength="20" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvTelefone" ControlToValidate="txtTelefone" ErrorMessage="Campo Telefone é Obrigatótio" ForeColor="Yellow" />
            <br />
        <asp:Label runat="server" Text="CEP" AssociatedControlID="txtCep" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtCep" CssClass="form-control cep " MaxLength="10" Width="200" />
        <asp:RequiredFieldValidator runat="server" ID="rfvCep" ControlToValidate="txtCep" ErrorMessage="Campo CEP é Obrigatótio" ForeColor="Yellow" />
            <br />
        <asp:Label runat="server" Text="Endereço" AssociatedControlID="txtEndereco" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtEndereco" CssClass="form-control" MaxLength="100" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvEndereco" ControlToValidate="txtEndereco" ErrorMessage="Campo Endereço é Obrigatótio" ForeColor="Yellow" />
            <br />
        <asp:Label runat="server" Text="Número" AssociatedControlID="txtNumero" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtNumero" CssClass="form-control" MaxLength="100" Width="100" />
        <asp:RequiredFieldValidator runat="server" ID="rfvNumero" ControlToValidate="txtNumero" ErrorMessage="Campo Número é Obrigatótio" ForeColor="Yellow" />
            <br />
        <asp:Label runat="server" Text="Complemento" AssociatedControlID="txtComplemento" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtComplemento" CssClass="form-control" MaxLength="100" Width="50%" />
            <br />
        <asp:Label runat="server" Text="Bairro" AssociatedControlID="txtBairro" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtBairro" CssClass="form-control" MaxLength="100" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvBairro" ControlToValidate="txtBairro" ErrorMessage="Campo Bairro é Obrigatótio" ForeColor="Yellow" />
            <br />
        <asp:Label runat="server" Text="Cidade" AssociatedControlID="txtCidade" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtCidade" CssClass="form-control" MaxLength="100" Width="50%" />
        <asp:RequiredFieldValidator runat="server" ID="rfvCidade" ControlToValidate="txtCidade" ErrorMessage="Campo Cidade é Obrigatótio" ForeColor="Yellow" />
            <br />
        <asp:Label runat="server" Text="Estado" AssociatedControlID="txtEstado" CssClass="text-light lead" />
        <asp:TextBox runat="server" ID="txtEstado" CssClass="form-control" MaxLength="2" Width="100" />
        <asp:RequiredFieldValidator runat="server" ID="rfvEstado" ControlToValidate="txtEstado" ErrorMessage="Campo Estado é Obrigatótio" ForeColor="Yellow" />

        <br />
        <br />
        <asp:Button ID="btnCadastar" runat="server" Text-="Cadastrar" CssClass="btn-secondary" OnClick="btnCadastar_Click" />
        
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" CssClass="text-light lead" />




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
