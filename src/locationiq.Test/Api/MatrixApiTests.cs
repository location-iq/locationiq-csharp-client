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
    ///  Class for testing MatrixApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MatrixApiTests
    {
        private MatrixApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MatrixApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatrixApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' MatrixApi
            //Assert.IsInstanceOf(typeof(MatrixApi), instance);
        }

        
        /// <summary>
        /// Test Matrix
        /// </summary>
        [Test]
        public void MatrixTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coordinates = null;
            //string bearings = null;
            //string radiuses = null;
            //string generateHints = null;
            //string approaches = null;
            //string exclude = null;
            //string annotations = null;
            //int sources = null;
            //int destinations = null;
            //decimal fallbackSpeed = null;
            //string fallbackCoordinate = null;
            //var response = instance.Matrix(coordinates, bearings, radiuses, generateHints, approaches, exclude, annotations, sources, destinations, fallbackSpeed, fallbackCoordinate);
            //Assert.IsInstanceOf(typeof(DirectionsMatrix), response, "response is DirectionsMatrix");
        }
        
    }

}
