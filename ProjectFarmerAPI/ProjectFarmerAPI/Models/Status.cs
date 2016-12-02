using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    /// <summary>
    /// The Status enum will be used for both order status and delivery status
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Error case
        /// </summary>
        None = -1,

        #region Order Creation and Delivery related status

        /// <summary>
        /// Order has been created
        /// </summary>
        OrderCreated = 100,
        /// <summary>
        /// Order is currently processing
        /// </summary>
        OrderProcessing = 101,
        /// <summary>
        /// Order has left for Delivery
        /// </summary>
        LeftForDelivery = 102,
        /// <summary>
        /// Order has been delivered to the customer
        /// </summary>
        OrderDelivered = 103,
        /// <summary>
        /// Due to some reason, the order couldn't be Delivered, the Reason will be given
        /// </summary>
        OrderCouldNotBeDelivered = 104,
        /// <summary>
        /// Order is completed sucessfully
        /// </summary>
        OrderCompleted = 105,
        #endregion

        #region Order cancelation or return related status

        /// <summary>
        /// Order return is processing
        /// </summary>
        OrderReturnProcessing = 200,
        /// <summary>
        /// Order Cancelation Request Processing
        /// </summary>
        OrderCancelationProcessing = 201,
        /// <summary>
        /// The pickup for this order scheduled
        /// </summary>
        OrderPickupScheduled = 202,
        /// <summary>
        /// The Order has been received to the store sucessfully.
        /// </summary>
        OrderReceivedBackSucessfully = 203,
        /// <summary>
        /// The Order hasn't been received to the store sucessfully.
        /// </summary>
        OrderReceivedBackUnSucessfully = 204,

        #endregion

        #region Payment related status
        
        /// <summary>
        /// The payment for this order is pending
        /// </summary>
        OrderPaymentPending = 300,

        #endregion
    }
}