﻿
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
        #region Constructor
        /// <summary>
        /// Constructor for the Election class. Requires data parameter.
        /// </summary>
        /// <param name="data">A csv-format string of the base electoral data.</param>
        /// <param name="pacts"></param>
        public Election(string data, Party[,] pacts = null)
        {
        }
        #endregion

        #region Public variables
        /// <summary>
        /// A value that represents the outcome of this election in a dictionary <c>PARTY, SEATS</c> format.
        /// </summary>
        public Dictionary<Party, int> Outcome
        {
            get
            {
                var outcome = new Dictionary<Party, int>();
                foreach (KeyValuePair<Constituency, Party> constituencyResult in this)
                {
                    outcome[constituencyResult.Value] += 1;
                    try
                    {

                    }
                    catch (KeyNotFoundException)
                    {
                        outcome.Add(constituencyResult.Value, 1);
                    }
                }
                return outcome;
            }
        }
        #endregion Public variables

        #region Data read and model construction
        #endregion

        #region Model logic
        #endregion

    }
}
