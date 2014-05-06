﻿using iWeibo.Adapters;
using iWeibo.WP8.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sinavm = iWeibo.WP8.ViewModels.Sina;
using tencentvm = iWeibo.WP8.ViewModels.Tencent;

namespace iWeibo.WP8.ViewModels
{
    public class ViewModelLocator : IDisposable
    {
        private readonly ContainerLocator containerLocator;
        private bool disposed;

        public ViewModelLocator()
        {
            this.containerLocator = new ContainerLocator();
        }

        public MainPageViewModel MainPageViewModel
        {
            get
            {
                return this.containerLocator.Container.Resolve<MainPageViewModel>();
            }
        }

        public Sina.LoginViewModel SinaLoginViewModel
        {
            get
            {
                return this.containerLocator.Container.Resolve<Sina.LoginViewModel>();
            }
        }

        public tencentvm.TimelineViewModel TencentTimelineViewModel
        {
            get
            {
                return this.containerLocator.Container.Resolve<tencentvm.TimelineViewModel>();
            }
        }

        //public TencentStatusDetailViewModel TencentStatusDetailViewModel
        //{
        //    get
        //    {
        //        return this.containerLocator.Container.Resolve<TencentStatusDetailViewModel>();
        //    }
        //}

        //public TencentRepostPageViewModel TencentRepostPageViewModel
        //{
        //    get
        //    {
        //        return this.containerLocator.Container.Resolve<TencentRepostPageViewModel>();
        //    }
        //}

        public sinavm.TimelineViewModel SinaTimelineViewModel
        {
            get
            {
                return this.containerLocator.Container.Resolve<sinavm.TimelineViewModel>();
            }
        }

        //public SinaStatusDetailViewModel SinaStatusDetailViewModel
        //{
        //    get
        //    {
        //        return this.containerLocator.Container.Resolve<SinaStatusDetailViewModel>();
        //    }
        //}

        //public SinaRepostPageViewModel SinaRepostPageViewModel
        //{
        //    get
        //    {
        //        return this.containerLocator.Container.Resolve<SinaRepostPageViewModel>();
        //    }
        //}

        public CreateNewViewModel PostNewViewModel
        {
            get
            {
                return this.containerLocator.Container.Resolve<CreateNewViewModel>();
            }
        }

        //public PictureViewViewModel PictureViewViewModel
        //{
        //    get
        //    {
        //        return this.containerLocator.Container.Resolve<PictureViewViewModel>();
        //    }
        //}

        //public SettingsViewModel SettingsViewModel
        //{
        //    get
        //    {
        //        return this.containerLocator.Container.Resolve<SettingsViewModel>();
        //    }
        //}

        public INavigationService NavigationService
        {
            get
            {
                return this.containerLocator.Container.Resolve<INavigationService>();
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
                return;
            if (disposing)
                this.containerLocator.Dispose();

            this.disposed = true;
        }
    }
}
