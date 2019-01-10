using RedMosquitoView.Models;
using RedMosquitoView.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedMosquitoView.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            WebCamList = new WebCamService().GetWebcams();
        }

        private List<WebCamItem> webCamList;
        public List<WebCamItem> WebCamList
        {
            get => webCamList;
            set => SetProperty(ref webCamList, value);
        }
    }
}
