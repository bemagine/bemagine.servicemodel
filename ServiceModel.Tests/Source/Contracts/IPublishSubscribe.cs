﻿//------------------------------------------------------------------------------------------------//
//  The contents of this file are subject to the Mozilla Public License Version 1.1 
//  (the "License"); you may not use this file except in compliance with the License. 
//  You may obtain a copy of the License at http://www.mozilla.org/MPL/
//
//  Software distributed under the License is distributed on an "AS IS" basis, WITHOUT 
//  WARRANTY OF ANY KIND, either express or implied. See the License for the specific 
//  language governing rights and limitations under the License.
//
//  The Original Code is Bemagine.ServiceModel.Tests.
//
//  The Initial Developer of the Original Code is Matthew Bologna, Bemagine.
//  Copyright (c) 2010-2012 Matthew Bologna, Bemagine. All rights reserved.
//------------------------------------------------------------------------------------------------//

namespace Bemagine.ServiceModel.Tests
{
    //--------------------------------------------------------------------------------------------//
    // using directives
    //--------------------------------------------------------------------------------------------//

    using System.ServiceModel;

    //--------------------------------------------------------------------------------------------//
    // contracts
    //--------------------------------------------------------------------------------------------//

    [ServiceContract(CallbackContract = typeof(IPublication), SessionMode = SessionMode.Required)]
    public interface ISubscription
    {
        [OperationContract(IsOneWay = true)]
        void SubscribeForPublication();

        [OperationContract(IsOneWay = true)]
        void UnsubscribeForPublication();

        [OperationContract(IsOneWay = true)]
        void SimulateUnexpectedServiceTermination();
    }

    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IPublication
    {
        [OperationContract(IsOneWay = true)]
        void OnPublication(string publicationData);
    }
}

//------------------------------------------------------------------------------------------------//
// end of file
//------------------------------------------------------------------------------------------------//
