
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

namespace Model.Models
{
    class Constituency
    {
        #region Constructor
        public Constituency()
        {

        }
        #endregion

        #region Public variables
        public string Name { get; set; }
        public string Region { get; set; }
        #endregion
    }
}
