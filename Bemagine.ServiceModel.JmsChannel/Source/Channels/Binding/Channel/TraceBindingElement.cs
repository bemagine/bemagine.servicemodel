﻿//------------------------------------------------------------------------------------------------//
//  The contents of this file are subject to the Mozilla Public License Version 1.1 
//  (the "License"); you may not use this file except in compliance with the License. 
//  You may obtain a copy of the License at http://www.mozilla.org/MPL/
//
//  Software distributed under the License is distributed on an "AS IS" basis, WITHOUT 
//  WARRANTY OF ANY KIND, either express or implied. See the License for the specific 
//  language governing rights and limitations under the License.
//
//  The Original Code is Bemagine.ServiceModel.JmsChannel.
//
//  The Initial Developer of the Original Code is Matthew Bologna, Bemagine.
//  Copyright (c) 2010-2012 Matthew Bologna, Bemagine. All rights reserved.
//------------------------------------------------------------------------------------------------//

namespace Bemagine.ServiceModel.Channels
{
    //--------------------------------------------------------------------------------------------//
    // using directives
    //--------------------------------------------------------------------------------------------//

    using System.ServiceModel.Channels;

    //--------------------------------------------------------------------------------------------//
    /// <summary>
    /// Binding element for the Trace channel.
    /// </summary>
    //--------------------------------------------------------------------------------------------//

    public sealed class TraceBindingElement : BindingElement
    {
        //----------------------------------------------------------------------------------------//
        /// <summary>
        /// Constructs a new TraceBindingElement instance.
        /// </summary>
        //----------------------------------------------------------------------------------------//

        public override BindingElement Clone()
        {
            return new TraceBindingElement();
        }

        //----------------------------------------------------------------------------------------//
        /// <summary>
        /// Interogates the context to determine if the property specified is supported.
        /// </summary>
        //----------------------------------------------------------------------------------------//

        public override T GetProperty<T>(BindingContext context)
        {
            return context.GetInnerProperty<T>();
        }

        //----------------------------------------------------------------------------------------//
        /// <summary>
        /// Returns true if TChannel is am IDuplexChannel and the inner channel can build the
        /// factory.
        /// </summary>
        //----------------------------------------------------------------------------------------//

        public override bool CanBuildChannelFactory<TChannel>(BindingContext context)
        {
            return (typeof(TChannel) == typeof(IDuplexChannel) && 
                context.CanBuildInnerChannelFactory<IDuplexChannel>());
        }

        //----------------------------------------------------------------------------------------//
        /// <summary>
        /// Returns true if TChannel is am IDuplexChannel and the inner channel can build the
        /// listener.
        /// </summary>
        //----------------------------------------------------------------------------------------//

        public override bool CanBuildChannelListener<TChannel>(BindingContext context)
        {
            return (typeof(TChannel) == typeof(IDuplexChannel) && 
                context.CanBuildInnerChannelListener<IDuplexChannel>());
        }

        //----------------------------------------------------------------------------------------//
        /// <summary>
        /// Constructs a TraceChannelFactory instance.
        /// </summary>
        //----------------------------------------------------------------------------------------//

        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(
            BindingContext context)
        {
            return (IChannelFactory<TChannel>)(object) new TraceChannelFactory(
                context.BuildInnerChannelFactory<IDuplexChannel>());
        }

        //----------------------------------------------------------------------------------------//
        /// <summary>
        /// Constructs a TraceChannelListener instance;
        /// </summary>
        //----------------------------------------------------------------------------------------//

        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(
            BindingContext context)
        {
            return (IChannelListener<TChannel>)(object) new TraceChannelListener(
                context.BuildInnerChannelListener<IDuplexChannel>());
        }
    }
}

//------------------------------------------------------------------------------------------------//
// end of file
//------------------------------------------------------------------------------------------------//
