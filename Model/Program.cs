
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
using Microsoft.VisualBasic.FileIO;
using Model.Models;

namespace Model
{
    class Program
    {
        #region Program foundational logic
        /// <summary>
        /// Initialisation code - the main thread - for the Program class.
        /// </summary>
        /// <param name="args">Any init arguments (datatype of argument is object).</param>
        static void Main(string[] args)
        {
            var path = /*INSERT PATH OF DATASET*/;
            Console.WriteLine(path);
            (data_ListOfConstituencies, data_ListOfParties) = ReadData(path);
        }
        #endregion

        #region Static variables
        static List<Constituency> data_ListOfConstituencies;
        static List<Party> data_ListOfParties;
        #endregion

        #region Data handling
        static (List<Constituency>, List<Party>) ReadData(string path)
        {
            List<Constituency> outputConsts = new List<Constituency>();
            List<Party> outputParties = new List<Party>();
            // Many thanks to Alexander Yumashev and editors for this CSV tip-off.
            // Attribution link: https://stackoverflow.com/a/20523165.
            using (TextFieldParser csvReader = new TextFieldParser(path) { TextFieldType = FieldType.Delimited, Delimiters = new string[] { "," } })
            {
                bool headers = true;
                while (!csvReader.EndOfData)
                {
                    string[] entry = csvReader.ReadFields();
                    if (headers)
                    {
                        for (int i = 3; i < entry.Length; i++)
                        {
                            outputParties.Add(new Party
                            {
                                Name = entry[i]
                            });
                        }
                        headers = false;

                    }
                    else
                    {
                        Constituency newConstituency = new Constituency
                        {
                            Name = entry[0],
                            Region = entry[1]
                        };
                        outputConsts.Add(newConstituency);
                    }
                }
            }
            return (outputConsts, outputParties);
        }
        #endregion
    }
}
