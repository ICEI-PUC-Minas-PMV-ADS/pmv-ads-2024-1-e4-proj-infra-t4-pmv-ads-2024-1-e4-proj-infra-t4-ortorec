import { View, Text, StyleSheet, Pressable } from 'react-native'
import { router } from "expo-router";
import React from 'react'

const registrar = () => {
  return (
    
    <View style={styles.container}>
      <Pressable
          style={({ pressed }) => [
            styles.button,
            pressed && { backgroundColor: '#A168ED'},
          ]}
          onPress={() => router.push('/home')}
          >
            <Text style={{ color: 'white', fontWeight: 'bold'}}> Ir para Homepage</Text>
      </Pressable>
    </View>
  )
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  button: {
    alignItems: 'center',
    justifyContent: 'center',
    paddingVertical: 26,
    paddingHorizontal: 48,
    borderRadius: 10,
    elevation: 3,
    backgroundColor: '#fb00ff',
    borderColor: '#fb00ff',
    padding: 20,
    margin: 10,
  },
})

export default registrar