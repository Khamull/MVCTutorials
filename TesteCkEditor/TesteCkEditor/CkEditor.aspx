<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CkEditor.aspx.cs" Inherits="TesteCkEditor.CkEditor" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <CKEditor:CKEditorControl ID="CKEditor1" BasePath="ckeditor/" runat="server"></CKEditor:CKEditorControl>
</asp:Content>
