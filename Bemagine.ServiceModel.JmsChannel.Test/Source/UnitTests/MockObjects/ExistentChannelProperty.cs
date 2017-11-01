﻿//------------------------------------------------------------------------------------------------//
//  The contents of this file are subject to the Mozilla Public License Version 1.1 
//  (the "License"); you may not use this file except in compliance with the License. 
//  You may obtain a copy of the License at http://www.mozilla.org/MPL/
//
//  Software distributed under the License is distributed on an "AS IS" basis, WITHOUT 
//  WARRANTY OF ANY KIND, either express or implied. See the License for the specific 
//  language governing rights and limitations under the License.
//
//  The Original Code is Bemagine.ServiceModel.JmsChannel.Test.
//
//  The Initial Developer of the Original Code is Matthew Bologna, Bemagine.
//  Copyright (c) 2010-2012 Matthew Bologna, Bemagine. All rights reserved.
//------------------------------------------------------------------------------------------------//

namespace Bemagine.ServiceModel.JmsChannel.Test
{
    //---------------------------------------------------------------------------------------------//
    /// <summary>
    /// An empty class implementation that models a channel property (e.g. encoding, custom 
    /// properties) that would be found via the GetProperty&lt;T&gt;() method as defined
    /// by the various System.ServiceModel.Channels interfaces (e.g. IChannelListener).
    /// </summary>
    //---------------------------------------------------------------------------------------------//

    internal sealed class ExistentChannelProperty 
    {
    }

    //---------------------------------------------------------------------------------------------//
    /// <summary>
    /// An empty class implementation that models a channel property (e.g. encoding, custom 
    /// properties) that would fail to be found by the GetProperty&lt;T&gt;() method as defined
    /// by the various System.ServiceModel.Channels interfaces (e.g. IChannelListener).
    /// </summary>
    //---------------------------------------------------------------------------------------------//

    internal sealed class NonExistentChannelProperty
    {
    }
}

//------------------------------------------------------------------------------------------------//
// end of file
//------------------------------------------------------------------------------------------------//
