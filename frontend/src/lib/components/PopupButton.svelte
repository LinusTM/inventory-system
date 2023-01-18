<script lang="ts">
	import { getContext } from 'svelte';
	import { fly } from 'svelte/transition';
	import PopupContent from './PopupContent.svelte';
	import CloseButton from './CloseButton.svelte';
	const { open }: any = getContext('simple-modal');

	const openPopup = () =>
		open(
			PopupContent,
			{ message: "It's a modal!" },
			{
				closeButton: CloseButton,
				styleWindow: {
					background: 'var(--background-secondary);',
				},

				styleContent: {
					color: 'var(--text-primary);',
				},

				transitionWindow: fly,

				transitionWindowProps: {
					y: 50,
					duration: 300,
				},
			},
		);
</script>

<button on:click={openPopup}>Open modal</button>

<style lang="scss">
	button {
		color: blueviolet;
	}
</style>
