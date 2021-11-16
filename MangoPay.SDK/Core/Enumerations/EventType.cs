﻿
using System;

namespace MangoPay.SDK.Core.Enumerations
{
    /// <summary>Event types enumeration.</summary>
	[Flags]
    public enum EventType : UInt64
    {
        All										= 0x0,

        PAYIN_NORMAL_CREATED					= 0x1,
        PAYIN_NORMAL_SUCCEEDED					= 0x2,
        PAYIN_NORMAL_FAILED						= 0x4,
        PAYOUT_NORMAL_CREATED					= 0x8,
        PAYOUT_NORMAL_SUCCEEDED					= 0x10,
        PAYOUT_NORMAL_FAILED					= 0x20,
        TRANSFER_NORMAL_CREATED					= 0x40,
        TRANSFER_NORMAL_SUCCEEDED				= 0x80,
        TRANSFER_NORMAL_FAILED					= 0x100,
        PAYIN_REFUND_CREATED					= 0x200,
        PAYIN_REFUND_SUCCEEDED					= 0x400,
        PAYIN_REFUND_FAILED						= 0x800,
        PAYOUT_REFUND_CREATED					= 0x1000,
        PAYOUT_REFUND_SUCCEEDED					= 0x2000,
        PAYOUT_REFUND_FAILED					= 0x4000,
        TRANSFER_REFUND_CREATED					= 0x8000,
        TRANSFER_REFUND_SUCCEEDED				= 0x10000,
        TRANSFER_REFUND_FAILED					= 0x20000,
        KYC_CREATED								= 0x40000,
        KYC_VALIDATION_ASKED					= 0x80000,
        KYC_SUCCEEDED							= 0x100000,
        KYC_FAILED								= 0x200000,
        PAYIN_REPUDIATION_CREATED				= 0x400000, 
        PAYIN_REPUDIATION_SUCCEEDED				= 0x800000, 
        PAYIN_REPUDIATION_FAILED				= 0x1000000,
        DISPUTE_DOCUMENT_CREATED				= 0x2000000, 
        DISPUTE_DOCUMENT_VALIDATION_ASKED		= 0x4000000, 
        DISPUTE_DOCUMENT_SUCCEEDED				= 0x8000000,
        DISPUTE_DOCUMENT_FAILED					= 0x10000000,
        DISPUTE_CREATED							= 0x20000000,
	    DISPUTE_SUBMITTED						= 0x40000000,
        DISPUTE_ACTION_REQUIRED					= 0x80000000,
        DISPUTE_FURTHER_ACTION_REQUIRED			= 0x100000000, 
        DISPUTE_CLOSED							= 0x200000000,
        DISPUTE_SENT_TO_BANK					= 0x400000000,
        TRANSFER_SETTLEMENT_CREATED				= 0x800000000,
        TRANSFER_SETTLEMENT_SUCCEEDED			= 0x1000000000,
		TRANSFER_SETTLEMENT_FAILED				= 0x2000000000,
		MANDATE_CREATED							= 0x4000000000,
		MANDATE_FAILED							= 0x8000000000,
		MANDATE_ACTIVATED						= 0x10000000000,
		MANDATE_SUBMITTED						= 0x20000000000,
		PREAUTHORIZATION_PAYMENT_WAITING		= 0x40000000000,
		PREAUTHORIZATION_PAYMENT_EXPIRED		= 0x80000000000,
		PREAUTHORIZATION_PAYMENT_CANCELED		= 0x100000000000,
		PREAUTHORIZATION_PAYMENT_VALIDATED		= 0x200000000000,
		UBO_DECLARATION_CREATED					= 0x400000000000,
		UBO_DECLARATION_VALIDATION_ASKED		= 0x800000000000,
		UBO_DECLARATION_REFUSED					= 0x1000000000000,
		UBO_DECLARATION_VALIDATED				= 0x2000000000000,
        UBO_DECLARATION_INCOMPLETE              = 0x4000000000000,
	    MANDATE_EXPIRED                         = 0x8000000000000,
	    USER_KYC_REGULAR                        = 0x10000000000000,
        KYC_OUTDATED                            = 0x20000000000000,
        USER_KYC_LIGHT                          = 0x40000000000000,
        USER_INFLOWS_BLOCKED                    = 0x80000000000000,
        USER_INFLOWS_UNBLOCKED                  = 0x100000000000000,
        USER_OUTFLOWS_BLOCKED                   = 0x200000000000000,
        USER_OUTFLOWS_UNBLOCKED                 = 0x400000000000000,
        PREAUTHORIZATION_CREATED                = 0x800000000000000,
        PREAUTHORIZATION_SUCCEEDED              = 0x1000000000000000,
        PREAUTHORIZATION_FAILED                 = 0x2000000000000000,

        INSTANT_PAYOUT_SUCCEEDED                = 0x4000000000000000,
        INSTANT_PAYOUT_FALLBACKED               = 0x8000000000000000

        /* IMPORTANT!
		 * 
		 * Anyone who will extend this enum: please note that this enum is FLAGS-attributed. 
		 * Pay attention to the numbers when adding new items, next value must be two times bigger.
		 * 
		 */
    }
}
