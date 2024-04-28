# patch

Patch is yet another jQuery.extend clone, but with a few extra quirks. It implements a protocol for "patching" objects in aribtrary ways, rather than simply "extending" objects. That is, rather than simply adding or replacing values in an object, it is possible to modify or delete existing values, too.

## overview

`patch` takes 3 or more arguments: options, the object to modify, and the object(s) to pull modifications from. The default behavior (i.e. with an empty `options` parameter) should seem intuitive, it will simply create a copy of the last argument:

    var patch = require('patch')

    var patched = patch({}, {}, {key: "value"})
    // patched = {key: "value"}
    
How about something a bit fancier? Let's tell `patch` to delete certain keys in the object being modified:

    var obj = {
        hello: "world",
        name: "steve"
    }
    var options = {
        delete: "delete this one"
    }
    patch(options, obj, {hello: "delete this one"}
    // => {name: "steve"}
    
Cool. Any key being updated to the value specified in the "delete" option is deleted instead. Note that keys that *already* have the "delete" value are *not* deleted.

What about arrays? Most `extend` clones simply replace values in the destination object, so if you have a large array you want to modify, you have to modify it and then pass in the whole thing. `patch` provides options for modifying existing arrays in-place, so you only have to pass in the new values:

    var obj = {
        numbers: [1,2,3,4,5]
    }
    var options = {
        arrays: 'prepend'
    }
    patch(options, obj, {numbers: [-2, -1, 0]})
    //=> {numbers: [-2, -1, 0, 1, 2, 3, 4, 5]}

Note that if the value does not exist in yet in the original object, the 'arrays' option is ignored.

Valid values for the "arrays" option are:

* `prepend` - prepend the given values to the existing array
* `append` - append the given values
* `replace` - throw out the old array and replace it with the new one (default behavior)
* `splice` - call [Array.splice](https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Global_Objects/Array/splice), passing in the new values as arguments to `splice` (uses Array.prototype.splice.apply(oldArr, newArr) under the hood). This allows arbirary modifications to an array - add/remove/replace arbitrary elements
* `join` - tired of that pesky array? Make it into a string in one fell swoop by calling "join". Specify a separator too, if you'd like.

## options

All options supported by `patch`:

- `deep` - boolean - default false - when true, patching is recursive on child objects and arrays, creating a deep copy
- `arrays` - prepend|append|replace|splice|join - default 'replace' - define patch behavior when an array already exists in the destination object
- `delete` - any - default none - any value being updated to this value will be deleted rather than updated

## why?

Why build yet another extend-like module? `patch` was designed to support partial object updates in a REST API. [RFC 5789](https://tools.ietf.org/html/rfc5789) defines the HTTP PATCH verb. Using the PATCH verb can save bandwidth compared to PUT or POST when updating resources, since a client only needs to send the updated bits. The RFC also describes some other advantages of using PATCH over other methods.

Consider a simple key-value REST API that stores JSON documents (see [patchstore](https://github.com/chesles/patchstore) for an example) that supports partial updates. Some challenges come up in writing such an API:

- what do you do with JSON documents with arbitrarily nested objects?
- How do you handle arrays? What if there is a long array that needs only a minor modification?
- How do you update a document, deleting a key rather than changing its value?

Using the `patch` module, such an API is easy to implement.
