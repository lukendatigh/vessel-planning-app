# Vessel Planning App
A desktop vessel manning app implemented in C# using Winforms and SQLite3

## Functional Requirements
- [x] Administration to manage manning officers
- [x] Authentication for manning officers to access the application
- [x] List vessels, seafarers and seafarer ranks
- [x] Query and sort vessels (by size, by type)
- [x] Query and sort seafarers (by rank, by time onboard, by time offboard, by seatime in current rank)
- [x] Query and sort ranks (by seatime)  
- [x] On-sign and off-sign seafarer to and from a vessel
- [x] Match seafarers who will sign off with those who are due to signin with a possible allowance for a 5 day offset
- [x] Implement seafarer matrix where no `Captain` and `1st Officer`, or `1st Engineer` and `2nd Engineer` have a cummulative seatime less than 36 months
- [x] Notify manning officer (user) of a signoff or signon that has been due for more than 3 days

#### Note:
- All sorting can be done in ascending or descending order
- The matrix calculation is implemented on launch of the app 

## Non-functional Requirements
- [x] Speed in CRUD 
- [ ] Data integrity (no database backups have been implemented)


## Built with
 - [Microsoft Visual Studio](https://www.visualstudio.com) - IDE
 - [SQLite](https://www.sqlite.com) - Database

