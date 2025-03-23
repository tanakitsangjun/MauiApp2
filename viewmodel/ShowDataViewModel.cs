using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp2.viewmodel;

public partial class ShowDataViewModel : ObservableObject
{
    [ObservableProperty]
    List<String> listData = ["One", "Two", "Three", "Four", "Five"];
}
