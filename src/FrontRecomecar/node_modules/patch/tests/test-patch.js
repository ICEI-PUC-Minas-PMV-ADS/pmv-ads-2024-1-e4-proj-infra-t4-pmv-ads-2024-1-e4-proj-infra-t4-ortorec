var specify = require('specify')
  , patch = require('../patch')

specify('basic patch', function(test) {
  var dest = {}
    , src = {value: true}
  dest = patch({}, dest, src);
  test.equal(dest.value, src.value)
  test.notEqual(dest, src)
})

specify('multiple source objects', function(test) {
  var a = {val1: 'test'}
    , b = {val2: 'test2'}

  var patched = patch({}, {}, a, b);

  test.equal(patched.val1, a.val1);
  test.equal(patched.val2, b.val2);
})

specify('recursive merge', function(test) {
  var src = {foo: { baz: "test"}}
  var patched = patch({deep: true}, {}, src);

  test.notEqual(patched.foo, src.foo);
  test.equal(patched.foo.baz, src.foo.baz);
})

specify('deletion', function(test) {
  var dest = {test: 123}
    , src = {test: '_'}

  var patched = patch({delete: '_'}, dest, src);

  test.deepEqual(patched.test, undefined);
})

specify('arrays - default', function(test) {
  var dest = { arr: [1,2,3] }
    , src = { arr: [3,2,1] }

  var patched = patch({deep:true}, dest, src);

  test.ok(patched.arr !== src.arr)
  test.ok(Array.isArray(patched.arr))
  test.equal(patched.arr[0], 3)
  test.equal(patched.arr[1], 2)
  test.equal(patched.arr[2], 1)
})

specify('arrays - prepend', function(test) {
  var dest = { arr: [75] }
    , src = { arr: [25, 50] }

  var patched = patch({arrays: 'prepend'}, dest, src)

  test.ok(Array.isArray(patched.arr))
  test.equal(patched.arr.length, 3)
  test.equal(patched.arr[0], 25)
  test.equal(patched.arr[1], 50)
  test.equal(patched.arr[2], 75)

  patched = patch({arrays: 'prepend'}, {}, src)
  test.ok(patched.arr === src.arr)
  test.ok(Array.isArray(patched.arr))
  test.equal(patched.arr.length, 2)
  test.equal(patched.arr[0], 25)
  test.equal(patched.arr[1], 50)

  dest = { o:{ a:[1] } }
  src = { a:[0], o:{ a:[1,2,3] } }
  patched = patch({arrays: 'prepend', deep: true}, dest, src)

  test.equal(patched.o.a.length, 4)
  test.equal(patched.o.a[0], 1)
  test.equal(patched.o.a[1], 2)
  test.equal(patched.o.a[2], 3)
  test.equal(patched.o.a[3], 1)

  test.equal(patched.a.length, 1)
  test.equal(patched.a[0], 0)
})

specify('arrays - append', function(test) {
  var dest = { arr: [75] }
    , src = { arr: [25, 50] }

  var patched = patch({arrays: 'append'}, dest, src)

  test.ok(Array.isArray(patched.arr))
  test.equal(patched.arr.length, 3)
  test.equal(patched.arr[0], 75)
  test.equal(patched.arr[1], 25)
  test.equal(patched.arr[2], 50)

  patched = patch({arrays: 'append'}, {}, src)
  test.ok(patched.arr === src.arr)
  test.equal(patched.arr.length, 2)
  test.equal(patched.arr[0], 25)
  test.equal(patched.arr[1], 50)

  dest = { o:{ a:[1] } }
  src = { a:[0], o:{ a:[1,2,3] } }
  patched = patch({arrays: 'append', deep: true}, dest, src)

  test.equal(patched.o.a.length, 4)
  test.equal(patched.o.a[0], 1)
  test.equal(patched.o.a[1], 1)
  test.equal(patched.o.a[2], 2)
  test.equal(patched.o.a[3], 3)

  test.equal(patched.a.length, 1)
  test.equal(patched.a[0], 0)
})

specify('arrays - replace', function(test) {
  var dest = { arr: [75] }
    , src = { arr: [25, 50] }

  var patched = patch({arrays: 'replace'}, dest, src)

  test.ok(Array.isArray(patched.arr))
  test.equal(patched.arr.length, 2)
  test.equal(patched.arr[0], 25)
  test.equal(patched.arr[1], 50)

  patched = patch({arrays: 'replace'}, {}, src)
  test.ok(patched.arr === src.arr)
  test.equal(patched.arr.length, 2)
  test.equal(patched.arr[0], 25)
  test.equal(patched.arr[1], 50)

  dest = { o:{ a:[1] } }
  src = { a:[0], o:{ a:[1,2,3] } }
  patched = patch({arrays: 'replace', deep: true}, dest, src)

  test.ok(patched.a !== src.a)
  test.ok(patched.o.a !== src.o.a)

  test.equal(patched.o.a.length, 3)
  test.equal(patched.o.a[0], 1)
  test.equal(patched.o.a[1], 2)
  test.equal(patched.o.a[2], 3)

  test.equal(patched.a.length, 1)
  test.equal(patched.a[0], 0)
})

specify('arrays - join', function(test) {
  var dest = { arr: [0, 25, 50, 75] }
    , src = { arr: ',' }

  var patched = patch({arrays: 'join'}, dest, src)

  test.ok(!Array.isArray(patched.arr))
  test.equal(patched.arr, '0,25,50,75')
})

specify.run();
