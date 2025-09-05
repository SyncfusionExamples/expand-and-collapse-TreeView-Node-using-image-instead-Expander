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
        <!--<treeview:SfTreeView.ExpanderTemplate>
            <DataTemplate>
               ...
                        <Image Source="{Binding IsExpanded,Converter={StaticResource ExpanderIconConverter}}"
                                       VerticalOptions="Center" 
                                       HorizontalOptions="Center"
                                       HeightRequest="35" 
                                       WidthRequest="35"/>
                            
                ...
            </DataTemplate>
        </treeview:SfTreeView.ExpanderTemplate>-->
    </treeview:SfTreeView>
</ContentPage.Content>
```

## Requirements to run the demo
Visual Studio 2017 or Visual Studio for Mac.
Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.