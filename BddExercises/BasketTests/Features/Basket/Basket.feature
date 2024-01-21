Feature: Shopping Basket API
  In order to amend my purchase before checking out, as a customer, 
  I want to be able to edit my shopping basket

  Background:
    Given I have the following data
      | Product ID | Stock Qty | Basket |
      | 1          | 2         | 0      |
      | 2          | 0         | 0      |
      | 3          | 2         | 1      |
      | 4          | 5         | 1      |

  Scenario Outline: Testing functionality of basket api
    Given I have a request to add product <Product>
    When I call the Add method of the basket api
    Then the quantities are
      | Product   | Stock   | Basket   |
      | <Product> | <Stock> | <Basket> |
    And a message <Message> is returned to the client

    Examples:
      | Test Description  | Product | Stock | Basket | Message               |
      | In stock          | 1       | 1     | 1      | 'Added to basket '    |
      | Not in stock      | 2       | 0     | 0      | 'Not in stock'        |
      | Already in basket | 3       | 2     | 1      | 'Limited to one only' |

#  Scenario: Customer can add product to basket
#    Given I have the following data
#      | Field     | Value |
#      | ProductId | 1     |
#      | StockQty  | 2     |
#      | Basket    | 0     |
#
#    #   | ProductId | Stock | Basket |
#    #   | 1         | 2     | 0      |
#
#    When I click the Add to Basket button
#    Then the quantities are
#      | Stock | Basket |
#      | 1     | 1      |
#    And a message 'Added to basket' is displayed to the customer