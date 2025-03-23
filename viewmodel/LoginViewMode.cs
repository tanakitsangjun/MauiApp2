using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp2.pages;

namespace MauiApp2.viewmodel;

public partial class LoginViewMode : ObservableObject
{
    [ObservableProperty]
    string username = "";
    [ObservableProperty]
    string password = "";

    [ObservableProperty]
    string route = nameof(registerpage);

    

    [RelayCommand]
    async Task Login(){
       
        await Gotopage(nameof(ShowDataPage));

    }

    [RelayCommand]
    async Task  Gotopage(string page){
        await Shell.Current.GoToAsync(page);
    }
}
