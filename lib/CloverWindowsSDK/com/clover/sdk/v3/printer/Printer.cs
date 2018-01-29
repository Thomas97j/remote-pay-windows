/**
 * Autogenerated by Avro
 * 
 * DO NOT EDIT DIRECTLY
 */

// Copyright (C) 2018 Clover Network, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
//
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;

namespace com.clover.sdk.v3.printer {


public class Printer {

  /// <summary>
  /// Unique identifier
  /// </summary>
  public String id { get; set; }

  /// <summary>
  /// MAC address of a network printer
  /// </summary>
  public String mac { get; set; }

  public String model { get; set; }

  public String name { get; set; }

  /// <summary>
  /// IP address of a network printer
  /// </summary>
  public String ipAddress { get; set; }

  /// <summary>
  /// NETWORK is a printer that's directly connected to the network.  MY_LOCAL represents the printer that's connected to the device that's making the request.
  /// </summary>
  public com.clover.sdk.v3.printer.PrinterType type { get; set; }

}

}
