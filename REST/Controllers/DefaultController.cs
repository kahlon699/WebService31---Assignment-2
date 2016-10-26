using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using SharedClasses;

namespace REST.Controllers
{
    [RoutePrefix("api/default")]
    public class DefaultController : ApiController
    {

        [HttpGet]
        [Route]

        //This is the case when string entered is Empty

        public IHttpActionResult ConvertToArray()
        {
            throw new HttpResponseException(
              new HttpResponseMessage(HttpStatusCode.BadRequest)
              {
                  Content = new StringContent("String cannot be empty"),
                  ReasonPhrase = "String cannot be empty"
              });



        }

        [HttpGet]
        [Route("{str}")]

       
        public IHttpActionResult ConvertToArray(string str)
        {
            if (str.Trim().Length==1)
                {
                throw new HttpResponseException(
              new HttpResponseMessage(HttpStatusCode.BadRequest)
              {
                  Content = new StringContent("String cannot contain single character"),
                  ReasonPhrase = "String cannot be empty"
              });
                }
            
            CustomClass cus = new CustomClass();

             cus.StrList=Regex.Split(str, @"\s+").Where(s => s != string.Empty).ToList();
            cus.UpperCase= str.ToUpper();
            cus.StringLength = str.Length;


            List<WordLength> list = new List<WordLength>();
            foreach (string wo in cus.StrList)
            {

                
                
                list.Add(new WordLength() { word = wo, length = wo.Length });

                
            }
            cus.WordLenList = list;
            return Ok(cus);
        }

    }
       


    
   
   
}