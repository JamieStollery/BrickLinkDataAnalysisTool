﻿using Data.Common;
using Data.Common.Model;
using Data.Common.Model.Dto;
using Data.Common.Option;
using Data.Common.Repository.Interface;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data.BrickLinkAPI
{
    public class ItemImageRepository : IItemImageRepository
    {
        private readonly IBrickLinkRequestFactory _requestFactory;
        private readonly IOption<User> _userOption;

        public ItemImageRepository(IBrickLinkRequestFactory requestFactory, IOption<User> userOption)
        {
            _requestFactory = requestFactory;
            _userOption = userOption;
        }

        public async Task<Stream> GetItemImage(string type, string no, int colorId)
        {
            var request = _requestFactory.Create($"items/{type}/{no}/images/{colorId}", _userOption.Value);

            var response = await request.GetResponseAsync();

            JObject json = null;
            using (var stream = response.GetResponseStream())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = JObject.Parse(jsonString);
            }
            
            var meta = json.SelectToken("meta");
            if (meta.Value<int>("code") == 200)
            {
                request = (HttpWebRequest)WebRequest.Create($"http:{json.SelectToken("data").Value<string>("thumbnail_url")}");
                response = await request.GetResponseAsync();
                return response.GetResponseStream();
            } 
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task<IEnumerable<ColorDto>> GetColors()
        {
            var request = _requestFactory.Create("colors", _userOption.Value);

            var response = await request.GetResponseAsync();

            JObject json = null;
            using (var stream = response.GetResponseStream())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = JObject.Parse(jsonString);
            }
            
            var meta = json.SelectToken("meta");
            if (meta.Value<int>("code") == 200)
            {
                return json.SelectToken("data").Select(token => token.ToObject<ColorDto>());
            } 
            else
            {
                throw new NotImplementedException();
            }

        }
    }
}
