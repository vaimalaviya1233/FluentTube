﻿using FluentTube.App.Models;
using FluentTube.App.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Media.Imaging;

namespace FluentTube.App.ViewModels
{
    public class HistoryViewModel
    {
        public HistoryViewModel(YouTubeService services)
        {
            _service = services;

            LoadUserHistoryPageCommand = new AsyncRelayCommand(LoadUserHistoryPageAsync);
        }

        private readonly YouTubeService _service;

        public IAsyncRelayCommand LoadUserHistoryPageCommand { get; }

        private async Task LoadUserHistoryPageAsync()
        {
        }
    }
}
