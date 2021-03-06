/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing FlexTokenApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FlexTokenApiTests
    {
        private FlexTokenApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlexTokenApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FlexTokenApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FlexTokenApi
            //Assert.IsInstanceOfType(typeof(FlexTokenApi), instance, "instance is a FlexTokenApi");
        }

        
        /// <summary>
        /// Test Tokenize
        /// </summary>
        [Test]
        public void TokenizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TokenizeRequest tokenizeRequest = null;
            //var response = instance.Tokenize(tokenizeRequest);
            //Assert.IsInstanceOf<FlexV1TokensPost200Response> (response, "response is FlexV1TokensPost200Response");
        }
        
    }

}
