import { View, Text, Pressable, StyleSheet } from 'react-native'
import React from 'react'

const CustomPress = () => {
  return (
    <Pressable style={styles.Pressable}>
      <Text></Text>
    </Pressable>
  )
}

const styles = StyleSheet.create({
  Pressable: {
    padding: 20,
    margin: 10,
    borderWidth: StyleSheet.hairlineWidth,
    borderRadius: 10,
    borderColor: '#fb00ff',
    backgroundColor: '#fb00ff',
  }
})
export default CustomPress