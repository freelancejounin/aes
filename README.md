This is an implementation of the FIPS197 specification for AES.
It takes the message and key as hex-strings and you can choose encryption or decryption.
Outputs include the key schedule and the state as each round begins, up to round 10.

* Note that this means keys of 192 or 256 bits still work correctly, but the output
does not show the rounds after the 10th. The final output, of course, is still shown.