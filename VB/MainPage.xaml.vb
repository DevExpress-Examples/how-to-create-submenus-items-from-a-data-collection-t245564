Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Bars
Imports System.Collections.ObjectModel
Imports System.Collections
Imports System.Collections.Specialized
Imports DevExpress.Xpf.Core

Namespace Q158708
    Partial Public Class MainPage
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            _Collection = New ObservableCollection(Of [MyClass])()
            _Collection.Add(New [MyClass]("Name1"))
            _Collection.Add(New [MyClass]("Name2"))
            _Collection.Add(New [MyClass]("Name3"))
            GenerateItems(manager, manager.Bars("bar"), _Collection)
        End Sub

        Private Sub sb_GetItemData(ByVal sender As Object, ByVal e As EventArgs)
            Dim sb As BarSubItem = DirectCast(sender, BarSubItem)
            sb1.ItemLinks.Add(New BarButtonItemLink() With {.BarItemName = "bt1"})
            sb1.ItemLinks.Add(New BarButtonItemLink() With {.BarItemName = "bt2"})
        End Sub

        Public Sub GenerateItems(ByVal manager As BarManager, ByVal holder As ILinksHolder, ByVal collection As IEnumerable)
            For Each item As [MyClass] In collection
                holder.Links.Add(GetBarItem(manager, item))
            Next item
        End Sub
        Public Function GetBarItem(ByVal manager As BarManager, ByVal data As [MyClass]) As BarItem
            Dim itemName As String = "button" & data.Name
            Dim item As BarItem = manager.Items(itemName)
            If item Is Nothing Then
                item = New BarButtonItem() With {.Name = itemName, .Content = data.Name}
            End If
            Return item
        End Function

        Private _Collection As ObservableCollection(Of [MyClass])
    End Class
End Namespace
