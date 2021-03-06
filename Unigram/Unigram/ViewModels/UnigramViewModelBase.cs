﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Services;
using Template10.Common;
using Template10.Mvvm;
using Unigram.Services;

namespace Unigram.ViewModels
{
    /// <summary>
    /// Base class for ViewModel
    /// </summary>
    public class UnigramViewModelBase : ViewModelBase
    {
        private readonly IMTProtoService _legacyService;

        private readonly IProtoService _protoService;
        private readonly ICacheService _cacheService;
        private readonly IEventAggregator _aggregator;

        private readonly IDispatcherWrapper _dispatcher;

        //public UnigramViewModelBase(IMTProtoService legacyService, ICacheService cacheService, IEventAggregator aggregator)
        //    : this(legacyService, cacheService, aggregator, null)
        //{
        //}

        //public UnigramViewModelBase(IMTProtoService legacyService, ICacheService cacheService, IEventAggregator aggregator, IDispatcherWrapper dispatcher)
        //{
        //    _legacyService = legacyService;
        //    _cacheService = cacheService;
        //    _aggregator = aggregator;

        //    _dispatcher = dispatcher;
        //}

        public UnigramViewModelBase(IProtoService protoService, ICacheService cacheService, IEventAggregator aggregator)
        {
            _protoService = protoService;
            _cacheService = cacheService;
            _aggregator = aggregator;
        }

        public UnigramViewModelBase(IProtoService protoService, IMTProtoService legacyService, ICacheService cacheService, IEventAggregator aggregator)
        {
            _protoService = protoService;
            _legacyService = legacyService;
            _cacheService = cacheService;
            _aggregator = aggregator;
        }

        //public override IDispatcherWrapper Dispatcher
        //{
        //    get
        //    {
        //        return _dispatcher;
        //    }
        //    set
        //    {

        //    }
        //}

        public IProtoService ProtoService
        {
            get
            {
                return _protoService;
            }
        }

        /// <summary>
        /// Gets a reference to the <see cref="Telegram.Api.Services.IMTProtoService"/> 
        /// class that handle API requests
        /// </summary>
        public IMTProtoService LegacyService
        {
            get
            {
                return _legacyService;
            }
        }

        /// <summary>
        /// Gets a refernce to the <see cref="Telegram.Api.Services.Cache.ICacheService"/> 
        /// class that represente in memory cache
        /// </summary>
        public ICacheService CacheService
        {
            get
            {
                return _cacheService;
            }
        }

        public IEventAggregator Aggregator
        {
            get
            {
                return _aggregator;
            }
        }

        private bool _isLoading;
        public virtual bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                Set(ref _isLoading, value);
            }
        }

        protected virtual void BeginOnUIThread(Action action)
        {
            var dispatcher = Dispatcher;
            if (dispatcher != null)
            {
                dispatcher.Dispatch(action);
            }
        }

        protected void NavigateOnUIThread(Type page)
        {
            NavigateOnUIThread(page, null);
        }

        protected void NavigateOnUIThread(Type page, object param)
        {
            BeginOnUIThread(() => NavigationService.Navigate(page, param));
        }
    }
}
