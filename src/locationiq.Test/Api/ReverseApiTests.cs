/* 
 * LocationIQ
 *
 * LocationIQ provides flexible enterprise-grade location based solutions. We work with developers, startups and enterprises worldwide serving billions of requests everyday. This page provides an overview of the technical aspects of our API and will help you get started.
 *
 * The version of the OpenAPI document: 1.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using locationiq.Client;
using locationiq.Api;
using locationiq.Model;

namespace locationiq.Test
{
    /// <summary>
    ///  Class for testing ReverseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReverseApiTests
    {
        private ReverseApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReverseApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReverseApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ReverseApi
            //Assert.IsInstanceOf(typeof(ReverseApi), instance);
        }

        
        /// <summary>
        /// Test Reverse
        /// </summary>
        [Test]
        public void ReverseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal lat = null;
            //decimal lon = null;
            //string format = null;
            //int normalizecity = null;
            //int addressdetails = null;
            //string acceptLanguage = null;
            //int namedetails = null;
            //int extratags = null;
            //int statecode = null;
            //int showdistance = null;
            //int postaladdress = null;
            //var response = instance.Reverse(lat, lon, format, normalizecity, addressdetails, acceptLanguage, namedetails, extratags, statecode, showdistance, postaladdress);
            //Assert.IsInstanceOf(typeof(Location), response, "response is Location");
        }
        
    }

}
