# Shuttle.Accounting
Generic accounting implementation.

***Please note***: This repository is still in development.  Please 'watch' if you'd like to receive notifications on updates.

### Design

- TransactionType
- Journal
- TransactionJournal (TransactionTypeID)
- FinancialAccount
  - Transaction (contains JournalID / TransactionJournalID)
- FinancialAccountOffset
- FinanceSchedule
  - Instalment
