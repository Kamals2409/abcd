Feature: Header
	In order view Header link
	As a user
	I want to be able to click on header links

@AmazonHeader
Scenario Outline: Amazon Header
	Given I have naviagate to Amazon
	When I Click on <Header Link>
	Then I can see <Header Link> Pages
Examples: 
| Header Link   |
| TodaysDeals |
| Vouchers      |
| AmazonBasics  |