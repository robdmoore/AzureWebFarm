﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using MvcContrib.PortableAreas;

namespace AzureWebFarm.ControlPanel.Areas.ControlPanel
{
    public class ControlPanelAreaRegistration : PortableAreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ControlPanel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ControlPanel_default",
                "ControlPanel/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            base.RegisterArea(context, new NopBus());
        }
    }

    internal class NopBus : IApplicationBus
    {
        public IEnumerator<Type> GetEnumerator()
        {
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Type item)
        {
        }

        public void Clear()
        {
        }

        public bool Contains(Type item)
        {
            return false;
        }

        public void CopyTo(Type[] array, int arrayIndex)
        {
        }

        public bool Remove(Type item)
        {
            return true;
        }

        public int Count
        {
            get { return 0; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public int IndexOf(Type item)
        {
            return -1;
        }

        public void Insert(int index, Type item)
        {
        }

        public void RemoveAt(int index)
        {
        }

        public Type this[int index]
        {
            get { return null; }
            set {  }
        }

        public void Send(IEventMessage eventMessage)
        {
        }

        public void SetMessageHandlerFactory(IMessageHandlerFactory factory)
        {
        }
    }
}
