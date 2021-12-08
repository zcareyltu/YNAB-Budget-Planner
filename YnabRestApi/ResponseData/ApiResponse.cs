﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YnabRestApi.ResponseData {
    public class ApiResponse<T> where T : new() {

        [JsonPropertyName("data")]
        public T Data { get; set; } = new T();

        //[JsonPropertyName("error")]
        //public YnabError? Error { get; set; }

        public override string ToString() {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true });
        }

    }
}
