using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavigatorChallenge.Models
{
    public class TestOrder
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.spscommerce.com/RSX", IsNullable = false)]
        public partial class Orders
        {

            private OrdersOrder orderField;

            /// <remarks/>
            public OrdersOrder Order
            {
                get
                {
                    return this.orderField;
                }
                set
                {
                    this.orderField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrder
        {

            private OrdersOrderHeader headerField;

            private OrdersOrderLineItem[] lineItemField;

            private OrdersOrderSummary summaryField;

            /// <remarks/>
            public OrdersOrderHeader Header
            {
                get
                {
                    return this.headerField;
                }
                set
                {
                    this.headerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("LineItem")]
            public OrdersOrderLineItem[] LineItem
            {
                get
                {
                    return this.lineItemField;
                }
                set
                {
                    this.lineItemField = value;
                }
            }

            /// <remarks/>
            public OrdersOrderSummary Summary
            {
                get
                {
                    return this.summaryField;
                }
                set
                {
                    this.summaryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderHeader
        {

            private OrdersOrderHeaderOrderHeader orderHeaderField;

            private OrdersOrderHeaderDates datesField;

            private OrdersOrderHeaderAddress[] addressField;

            private OrdersOrderHeaderCarrierInformation carrierInformationField;

            private OrdersOrderHeaderReferences referencesField;

            private OrdersOrderHeaderChargesAllowances chargesAllowancesField;

            /// <remarks/>
            public OrdersOrderHeaderOrderHeader OrderHeader
            {
                get
                {
                    return this.orderHeaderField;
                }
                set
                {
                    this.orderHeaderField = value;
                }
            }

            /// <remarks/>
            public OrdersOrderHeaderDates Dates
            {
                get
                {
                    return this.datesField;
                }
                set
                {
                    this.datesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Address")]
            public OrdersOrderHeaderAddress[] Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            public OrdersOrderHeaderCarrierInformation CarrierInformation
            {
                get
                {
                    return this.carrierInformationField;
                }
                set
                {
                    this.carrierInformationField = value;
                }
            }

            /// <remarks/>
            public OrdersOrderHeaderReferences References
            {
                get
                {
                    return this.referencesField;
                }
                set
                {
                    this.referencesField = value;
                }
            }

            /// <remarks/>
            public OrdersOrderHeaderChargesAllowances ChargesAllowances
            {
                get
                {
                    return this.chargesAllowancesField;
                }
                set
                {
                    this.chargesAllowancesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderHeaderOrderHeader
        {

            private string tradingPartnerIdField;

            private ushort purchaseOrderNumberField;

            private byte tsetPurposeCodeField;

            private System.DateTime purchaseOrderDateField;

            /// <remarks/>
            public string TradingPartnerId
            {
                get
                {
                    return this.tradingPartnerIdField;
                }
                set
                {
                    this.tradingPartnerIdField = value;
                }
            }

            /// <remarks/>
            public ushort PurchaseOrderNumber
            {
                get
                {
                    return this.purchaseOrderNumberField;
                }
                set
                {
                    this.purchaseOrderNumberField = value;
                }
            }

            /// <remarks/>
            public byte TsetPurposeCode
            {
                get
                {
                    return this.tsetPurposeCodeField;
                }
                set
                {
                    this.tsetPurposeCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime PurchaseOrderDate
            {
                get
                {
                    return this.purchaseOrderDateField;
                }
                set
                {
                    this.purchaseOrderDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderHeaderDates
        {

            private byte dateTimeQualifierField;

            private System.DateTime dateField;

            /// <remarks/>
            public byte DateTimeQualifier
            {
                get
                {
                    return this.dateTimeQualifierField;
                }
                set
                {
                    this.dateTimeQualifierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderHeaderAddress
        {

            private string addressTypeCodeField;

            private byte locationCodeQualifierField;

            private ushort addressLocationNumberField;

            private string addressNameField;

            private string address1Field;

            private string address2Field;

            private string cityField;

            private string stateField;

            private ushort postalCodeField;

            private string countryField;

            /// <remarks/>
            public string AddressTypeCode
            {
                get
                {
                    return this.addressTypeCodeField;
                }
                set
                {
                    this.addressTypeCodeField = value;
                }
            }

            /// <remarks/>
            public byte LocationCodeQualifier
            {
                get
                {
                    return this.locationCodeQualifierField;
                }
                set
                {
                    this.locationCodeQualifierField = value;
                }
            }

            /// <remarks/>
            public ushort AddressLocationNumber
            {
                get
                {
                    return this.addressLocationNumberField;
                }
                set
                {
                    this.addressLocationNumberField = value;
                }
            }

            /// <remarks/>
            public string AddressName
            {
                get
                {
                    return this.addressNameField;
                }
                set
                {
                    this.addressNameField = value;
                }
            }

            /// <remarks/>
            public string Address1
            {
                get
                {
                    return this.address1Field;
                }
                set
                {
                    this.address1Field = value;
                }
            }

            /// <remarks/>
            public string Address2
            {
                get
                {
                    return this.address2Field;
                }
                set
                {
                    this.address2Field = value;
                }
            }

            /// <remarks/>
            public string City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public string State
            {
                get
                {
                    return this.stateField;
                }
                set
                {
                    this.stateField = value;
                }
            }

            /// <remarks/>
            public ushort PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public string Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderHeaderCarrierInformation
        {

            private string carrierTransMethodCodeField;

            private string carrierAlphaCodeField;

            private string carrierRoutingField;

            private string equipmentDescriptionCodeField;

            /// <remarks/>
            public string CarrierTransMethodCode
            {
                get
                {
                    return this.carrierTransMethodCodeField;
                }
                set
                {
                    this.carrierTransMethodCodeField = value;
                }
            }

            /// <remarks/>
            public string CarrierAlphaCode
            {
                get
                {
                    return this.carrierAlphaCodeField;
                }
                set
                {
                    this.carrierAlphaCodeField = value;
                }
            }

            /// <remarks/>
            public string CarrierRouting
            {
                get
                {
                    return this.carrierRoutingField;
                }
                set
                {
                    this.carrierRoutingField = value;
                }
            }

            /// <remarks/>
            public string EquipmentDescriptionCode
            {
                get
                {
                    return this.equipmentDescriptionCodeField;
                }
                set
                {
                    this.equipmentDescriptionCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderHeaderReferences
        {

            private string referenceQualField;

            private string referenceIDField;

            /// <remarks/>
            public string ReferenceQual
            {
                get
                {
                    return this.referenceQualField;
                }
                set
                {
                    this.referenceQualField = value;
                }
            }

            /// <remarks/>
            public string ReferenceID
            {
                get
                {
                    return this.referenceIDField;
                }
                set
                {
                    this.referenceIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderHeaderChargesAllowances
        {

            private string allowChrgIndicatorField;

            private string allowChrgCodeField;

            private decimal allowChrgAmtField;

            /// <remarks/>
            public string AllowChrgIndicator
            {
                get
                {
                    return this.allowChrgIndicatorField;
                }
                set
                {
                    this.allowChrgIndicatorField = value;
                }
            }

            /// <remarks/>
            public string AllowChrgCode
            {
                get
                {
                    return this.allowChrgCodeField;
                }
                set
                {
                    this.allowChrgCodeField = value;
                }
            }

            /// <remarks/>
            public decimal AllowChrgAmt
            {
                get
                {
                    return this.allowChrgAmtField;
                }
                set
                {
                    this.allowChrgAmtField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderLineItem
        {

            private OrdersOrderLineItemOrderLine orderLineField;

            /// <remarks/>
            public OrdersOrderLineItemOrderLine OrderLine
            {
                get
                {
                    return this.orderLineField;
                }
                set
                {
                    this.orderLineField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderLineItemOrderLine
        {

            private byte lineSequenceNumberField;

            private string buyerPartNumberField;

            private string vendorPartNumberField;

            private string consumerPackageCodeField;

            private byte orderQtyField;

            private string orderQtyUOMField;

            private decimal purchasePriceField;

            /// <remarks/>
            public byte LineSequenceNumber
            {
                get
                {
                    return this.lineSequenceNumberField;
                }
                set
                {
                    this.lineSequenceNumberField = value;
                }
            }

            /// <remarks/>
            public string BuyerPartNumber
            {
                get
                {
                    return this.buyerPartNumberField;
                }
                set
                {
                    this.buyerPartNumberField = value;
                }
            }

            /// <remarks/>
            public string VendorPartNumber
            {
                get
                {
                    return this.vendorPartNumberField;
                }
                set
                {
                    this.vendorPartNumberField = value;
                }
            }

            /// <remarks/>
            public string ConsumerPackageCode
            {
                get
                {
                    return this.consumerPackageCodeField;
                }
                set
                {
                    this.consumerPackageCodeField = value;
                }
            }

            /// <remarks/>
            public byte OrderQty
            {
                get
                {
                    return this.orderQtyField;
                }
                set
                {
                    this.orderQtyField = value;
                }
            }

            /// <remarks/>
            public string OrderQtyUOM
            {
                get
                {
                    return this.orderQtyUOMField;
                }
                set
                {
                    this.orderQtyUOMField = value;
                }
            }

            /// <remarks/>
            public decimal PurchasePrice
            {
                get
                {
                    return this.purchasePriceField;
                }
                set
                {
                    this.purchasePriceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.spscommerce.com/RSX")]
        public partial class OrdersOrderSummary
        {

            private decimal totalAmountField;

            private byte totalLineItemNumberField;

            /// <remarks/>
            public decimal TotalAmount
            {
                get
                {
                    return this.totalAmountField;
                }
                set
                {
                    this.totalAmountField = value;
                }
            }

            /// <remarks/>
            public byte TotalLineItemNumber
            {
                get
                {
                    return this.totalLineItemNumberField;
                }
                set
                {
                    this.totalLineItemNumberField = value;
                }
            }
        }


    }
}
