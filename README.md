# AuthX

AuthX is a lightweight authentication system that utilizes Pastebin as a storage platform for user credentials. It allows you to authenticate users based on their hardware ID (HWID) and PC name, granting access to specific features or content based on subscription expiry dates. It is released under the GNU General Public License v3.0.

## License

AuthX is licensed under the GNU General Public License v3.0 (GPL-3.0). This means that you are free to use, modify, and distribute the library under the terms of this license. However, it is important to note the following:

- Skidding (repackaging and claiming as one's own) is strictly prohibited.
- Selling or monetizing AuthX as proprietary software is not allowed.
- Any modifications or derivative works based on AuthX must also be released under the GPL-3.0 license.

Please read the [LICENSE](LICENSE) file for the full text of the GNU General Public License v3.0.

## Usage
```
1. Insert your Pastebin RAW URL in the provided placeholder.
2. Run the `Request()` function to authenticate the user.
3. AuthX will fetch the user credentials from Pastebin and compare them with the current HWID and PC name.
4. Depending on the authentication result, different response messages will be displayed in the console.

Warning: AuthX for private projects only. Lacks protection against hacking or reversing. Not suitable for production use.
```

## Current Features

AuthX offers the following features:
- Pastebin integration for easy user credential management.
- HWID and PC name verification.
- Subscription-based access control with expiry dates.
- Customizable response messages for informative feedback.

Stay tuned for more updates and enhancements to AuthX.
