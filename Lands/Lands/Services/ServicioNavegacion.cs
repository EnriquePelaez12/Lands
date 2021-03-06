﻿using Lands.ViewModels;
using Lands.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lands.Services
{
    public class ServicioNavegacion
    {
        private static ServicioNavegacion m_instancia;
        private IDictionary<Type, Type> viewModelRouting = new Dictionary<Type, Type>()
        {
            { typeof(ListaTareasViewModel),  typeof(ListaTareasView) },
            { typeof(TareaViewModel),  typeof(TareaView) }
        };

        public static ServicioNavegacion Instancia
        {
            get
            {
                if (m_instancia == null)
                {
                    m_instancia = new ServicioNavegacion();
                }

                return m_instancia;
            }
        }

        async public Task NavigateTo<TDestinationViewModel>(object navigationContext = null)
        {
            Type pageType = viewModelRouting[typeof(TDestinationViewModel)];
            var page = Activator.CreateInstance(pageType) as Page;
            page.BindingContext = navigationContext;

            if (page != null)
                await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(page);
        }

        async public Task NavigateTo(Type destinationType, object navigationContext = null)
        {
            Type pageType = viewModelRouting[destinationType];
            var page = Activator.CreateInstance(pageType) as Page;
            page.BindingContext = navigationContext;

            if (page != null)
                await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public void NavigateBack()
        {
            Device.BeginInvokeOnMainThread(async () => await Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync());
        }

    }
}
