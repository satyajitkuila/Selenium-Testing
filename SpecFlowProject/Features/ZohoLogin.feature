Feature: ZohoLogin

  Scenario Outline: Login to ZOHO
    Given Zoho user on login page
    When the user on zoho enters <username> and <password>
    And he clicks on login button on zoho
    When Zoho user is navigated to the home page
    Then Close the browser on ZOHO

    Examples: 
      | username                   | password |
      | raghav12                   |   123456 |
      | ekhfejdj                   |  1234567 |
      | samuelwitwicky56@gmail.com | kanhu143 |