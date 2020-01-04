# Vessel Planning App
A desktop vessel manning app implemented in C# using Winforms and SQLite3

## Functional Requirements
1. `Authentication and Authorization` of *Manning Officers* to access the application
2. `List` vessels, seafarers and seafarer ranks
3. `Query and sort vessels` (by size, by type)
4. `Query and sort seafarers` (by rank, by time onboard, by time offboard, by seatime in current rank)
5. `Query and sort ranks` (by seatime)  
6. `On-sign` and `off-sign` seafarer to and from a vessel
7. `Match` seafarers *who are due for sign off* with those *who are due for signin*, with an allowance of a *5-day offset*
8. `Automate Officers' matrix` calculation where no *Captain* and *1st Officer*, or *1st Engineer* and *2nd Engineer* have a cummulative seatime less than 36 months
9. `Notify` manning officer (user) of a signoff or signon that has been due for more than *3 days*

#### Note:
- Sorting can be done in ascending and descending order
- `Officers' matrix` calculation occurs on app launch (bootup time can be a few milliseconds longer)

## Non-functional Requirements
- [x] Speed in CRUD 
- [ ] Data integrity (no database backups have been implemented)


## Built with
 - [Microsoft Visual Studio](https://www.visualstudio.com) - IDE
 - [SQLite](https://www.sqlite.com) - Database

