# expand-and-collapse-TreeView-Node-using-image-instead-Expander
This example demonstrates how to customize node expansion and collapse in the Syncfusion Xamarin.Forms TreeView by using an image as the toggle indicator instead of the default expander icon.

## Sample

### XAML
```xaml
<ContentPage.Resources>
    <ResourceDictionary>
        <local:ExpanderIconVisibilityConverter x:Key="ExpanderIconVisibilityConverter"/>
        <local:ExpanderIconConverter x:Key="ExpanderIconConverter" />
    </ResourceDictionary>
</ContentPage.Resources>
<ContentPage.Content>
    <treeview:SfTreeView x:Name="treeView"
                         Indentation="40"
                           ItemHeight="40"
                           ExpanderWidth="0"
                         AutoExpandMode="None"
                         ItemTemplateContextType="Node"
                         ChildPropertyName="SubFiles"
                         ItemsSource="{Binding ImageNodeInfo}">
        <treeview:SfTreeView.ItemTemplate>
            <DataTemplate>
                ...
                            <Image Grid.Column="2" Source="{Binding IsExpanded,Converter={StaticResource ExpanderIconConverter}}"
                                   IsVisible="{Binding HasChildNodes,Converter={StaticResource ExpanderIconVisibilityConverter}}"
                                       VerticalOptions="Center" 
                                       HorizontalOptions="Center"
                                       HeightRequest="35" 
                                       WidthRequest="35">

                                <Image.GestureRecognizers>
                                    <TapGestureRecognizer Tapped="TapGestureRecognizer_Tapped" />
                                </Image.GestureRecognizers>
                            </Image>
                       ...
            </DataTemplate>                
        </treeview:SfTreeView.ItemTemplate>
    </treeview:SfTreeView>
</ContentPage.Content>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for Xamarin](https://help.syncfusion.com/xamarin/system-requirements)

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
