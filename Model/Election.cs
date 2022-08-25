
/*
 * COPYRIGHT (C) 2022 MICHAEL HARGREAVES 
 * ALL RIGHTS RESERVED
 * contact@michaelrh04.co.uk
 * 
 * This file is part of the electoral-pact-transfer-model project. 
 * It is subject to the license terms in the LICENSE file found in 
 * the top-level directory of this distribution and at 
 * https://github.com/michaelrh04/electoral-pact-transfer-model. 
 * 
 * No part of lectoral-pact-transfer-model, including this file, 
 * may be copied, modified, propagated, or distributed except 
 * according to the terms contained in the LICENSE file.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Models;

namespace Model
{
    /// <summary>
    /// <para>Class for the operation of elections.
    /// Inherits dictionary data structure: note the structure of
    /// <c>CONSTITUENCY, PARTY_OF_VICTOR.</c></para>
    /// </summary>
    class Election : Dictionary<Constituency, Party>
    {
    }
}
