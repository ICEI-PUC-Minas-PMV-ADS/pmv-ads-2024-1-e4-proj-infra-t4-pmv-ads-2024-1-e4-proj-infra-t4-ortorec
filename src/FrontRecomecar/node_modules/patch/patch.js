/*
 * patch(opts, dest, src[, src2...])
 *
 * merge src objects into dest
 *
 * options:
 *  - delete - any value - keys that exist in the destination object, which
 *    would be updated to the value contained in the 'delete' option are
 *    deleted
 *  - deep - boolean - if true, do a deep (recursive) copy of objects
 */
function patch(opts, dest) {
  Array.prototype.slice.call(arguments, 2).forEach(function(src) {
    if (Array.isArray(dest)) {
      if (opts.arrays === 'prepend') {
        Array.prototype.unshift.apply(dest, src)
      }
      else if (opts.arrays === 'append') {
        Array.prototype.push.apply(dest, src)
      }
      else if (opts.arrays === 'splice') {
        Array.prototype.splice.apply(dest, src)
      }
      else if (opts.arrays === 'join') {
        dest = dest.join(src)
      }
      else if (!('arrays' in opts) || opts.arrays === 'replace') {
        dest = ('deep' in opts && opts.deep)
          ? src.slice()
          : src
      }
      else {
        throw new Error('Unknown option for "arrays" option:'+opts.arrays)
      }
    }
    else {
      Object.keys(src).forEach(function(key) {
        if ('delete' in opts && src[key] === opts.delete) {
          delete dest[key];
        }
        else {
          if (isArray(dest[key]) || isArray(src[key])) {
            if (dest[key] === undefined) {
              dest[key] = opts.deep ? patch(opts, [], src[key]) : src[key]
            }
            else {
              dest[key] = patch(opts, dest[key] || [], src[key])
            }
          }
          else if (isObject(src[key]) && opts.deep) {
            dest[key] = patch(opts, dest[key] || {}, src[key])
          }
          // not an object or an array
          else {
            dest[key] = src[key]
          }
        }
      });
    }
  });
  return dest;
}

function isObject(o) {
  return o === Object(o);
}
function isArray(a) {
  return Array.isArray(a);
}

module.exports = patch;
