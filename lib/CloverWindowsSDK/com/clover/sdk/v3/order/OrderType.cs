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

namespace com.clover.sdk.v3.order {


public class OrderType {

  /// <summary>
  /// Unique identifier
  /// </summary>
  public String id { get; set; }

  /// <summary>
  /// Label Key
  /// </summary>
  public String labelKey { get; set; }

  /// <summary>
  /// Label Key
  /// </summary>
  public String label { get; set; }

  /// <summary>
  /// If this order type is taxable
  /// </summary>
  public Boolean taxable { get; set; }

  /// <summary>
  /// If this order type is the default
  /// </summary>
  public Boolean isDefault { get; set; }

  /// <summary>
  /// If set to false, then this order type includes all of the merchant's categories. Otherwise, it only contains the categories defined in the "categories" field on this object.
  /// </summary>
  public Boolean filterCategories { get; set; }

  /// <summary>
  /// If this order type is hidden on the register
  /// </summary>
  public Boolean isHidden { get; set; }

  /// <summary>
  /// The price of a fee added to this order type
  /// </summary>
  public Int64 fee { get; set; }

  /// <summary>
  /// The minimum amount required for an order to be placed
  /// </summary>
  public Int64 minOrderAmount { get; set; }

  /// <summary>
  /// The maximum amount for an order allowed
  /// </summary>
  public Int64 maxOrderAmount { get; set; }

  /// <summary>
  /// The maximum radius allowed for an order (i.e. delivery)
  /// </summary>
  public Int64 maxRadius { get; set; }

  /// <summary>
  /// The average time it takes to complete the order
  /// </summary>
  public Int64 avgOrderTime { get; set; }

  public com.clover.sdk.v3.order.HoursAvailable hoursAvailable { get; set; }

  public com.clover.sdk.v3.order.CustomerIdMethod customerIdMethod { get; set; }

  /// <summary>
  /// If this order type is deleted
  /// </summary>
  public Boolean isDeleted { get; set; }

  /// <summary>
  /// Optional system order type that this order type is associated with.
  /// </summary>
  public String systemOrderTypeId { get; set; }

  /// <summary>
  /// The hours this order type is available (if they differ from normal merchant hours)
  /// </summary>
  public com.clover.sdk.v3.hours.HoursSet hours { get; set; }

  /// <summary>
  /// The categories of items that can be assigned to this order type
  /// </summary>
  public List<com.clover.sdk.v3.base_.Reference> categories { get; set; }

}

}
