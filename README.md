# Shuttle.Accounting

Generic accounting implementation.

***Please note***: This repository is still in development.  Please 'watch' if you'd like to receive notifications on updates.

### Design

- TransactionType
- PostingRules
- Journal
  - PostingId
- JournalTransaction (TransactionTypeID)
  - Groups individual transaction e.g. Amount + VAT (2 transactions)
- AccountType
- Account
  - Transactions (contains JournalID / TransactionJournalID)
    - Period (when transaction occurred)
    - EffectivePeriod (period that transaction applies to)
      - Transaction may be effected today but represents arrears so perhaps 6 months ago and should go into ageing bucket
    - **Allocations** (on transaction)
  - AgeingBuckets
- AccountOffset
- FinanceSchedule
  - Instalment
