//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace FashionZone.DataLayer.Model
{
    public partial class PAYPAL_PAYMENT
    {
        #region Primitive Properties
    
        public virtual int ID
        {
            get { return _iD; }
            set
            {
                if (_iD != value)
                {
                    if (PAYMENT != null && PAYMENT.ID != value)
                    {
                        PAYMENT = null;
                    }
                    _iD = value;
                }
            }
        }
        private int _iD;
    
        public virtual Nullable<decimal> Amount
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> PaidOn
        {
            get;
            set;
        }
    
        public virtual string Currency
        {
            get;
            set;
        }
    
        public virtual string PaypalEmail
        {
            get;
            set;
        }
    
        public virtual string PayerEmail
        {
            get;
            set;
        }
    
        public virtual string TransactionKey
        {
            get;
            set;
        }
    
        public virtual string TransactionStatus
        {
            get;
            set;
        }
    
        public virtual string CartID
        {
            get;
            set;
        }
    
        public virtual string Response
        {
            get;
            set;
        }
    
        public virtual string PayerStatus
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> Fee
        {
            get;
            set;
        }
    
        public virtual string PayerName
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual PAYMENT PAYMENT
        {
            get { return _pAYMENT; }
            set
            {
                if (!ReferenceEquals(_pAYMENT, value))
                {
                    var previousValue = _pAYMENT;
                    _pAYMENT = value;
                    FixupPAYMENT(previousValue);
                }
            }
        }
        private PAYMENT _pAYMENT;

        #endregion

        #region Association Fixup
    
        private void FixupPAYMENT(PAYMENT previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.PAYPAL_PAYMENT, this))
            {
                previousValue.PAYPAL_PAYMENT = null;
            }
    
            if (PAYMENT != null)
            {
                PAYMENT.PAYPAL_PAYMENT = this;
                if (ID != PAYMENT.ID)
                {
                    ID = PAYMENT.ID;
                }
            }
        }

        #endregion

    }
}