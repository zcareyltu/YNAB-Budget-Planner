﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YnabRestApi.ResponseData {
    public class PayeeLocationData {

        [JsonPropertyName("payee_location")]
        public PayeeLocation PayeeLocation { get; set; } = new();


        public override string ToString() {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true });
        }

    }

    /*
payee_location*	PayeeLocation{...}
     */
}
