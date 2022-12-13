# Our Application

## Our API

### HTTP-Based

"Resource Oriented Architecture"

- Resources
    - Important things to expose to API users
    - Resources have names (Uniform Resource Identifier - URI)
        
        Ex: `https://api.hypertheory.com:1338/policies/co?type=motorcycle`
        
        `https://` - *Scheme*
        Https is Transport-Layer Security - encrypted on the transport layer.
        Requires combination of symmetric and asymetric encryption using x-509 certificates

        `api.hypertheory.com` - "server" or "authority"

        `1338` - TCP Port. Default for HTTP is port 80, port 443 for HTTPS.

## HTTP

"Application layer" protocol

"Application Layer" - how two applications speak.

"Transport Layer" - how two applications connect or send messages to each other across internet
    - TCP (Transmission Control Protocol)
        - What HTTP uses
        - Stateful - client makes connection and connection is maintained for duration of transmission
